using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Be.IO;

namespace cswtool
{
    internal class csw
    {
        public List<cswEntry> entries = new List<cswEntry>();

        public void readFromStream(BeBinaryReader read)
        {
            var size = read.ReadInt32();
            var count = read.ReadInt32();
            entries = new List<cswEntry>(count);
            var offsets = util.readInt32Array(read, count);
            for (int i = 0; i < count; i++)
            {
                read.BaseStream.Position = offsets[i];
                entries.Add(cswEntry.createFromStream(read));
            }
        }

        private string readString(BeBinaryReader read)
        {
            var ofs = read.BaseStream.Position;
            byte nextbyte;
            byte[] name = new byte[32];

            int count = 0;
            while ((nextbyte = read.ReadByte()) != 0xFF & nextbyte != 0x00)
            {
                name[count] = nextbyte;
                count++;
            }
            return Encoding.ASCII.GetString(name, 0, count);
        }


        public void readBCTFromStream(BeBinaryReader read)
        {
            var count = read.ReadInt32();
            var dataOffset = read.ReadInt32();
            var namelistOffset = read.ReadInt32();
            read.BaseStream.Position = dataOffset;
            for (int i = 0; i < count; i++)
                entries[i].readBCTDataFromStream(read);

            read.BaseStream.Position = namelistOffset;
            var nameOffsets = util.readInt32Array(read, count);

            for (int i=0; i < count; i++)
            {
                read.BaseStream.Position = nameOffsets[i];
                entries[i].Name = readString(read);
            }
        }

        public static csw createFromStream(BeBinaryReader read)
        {
            var bb = new csw();
            bb.readFromStream(read);
            return bb;
        }

        public void writeToStream(BeBinaryWriter wrt)
        {
            wrt.Write(0);
            wrt.Write(entries.Count);
            //// PREWRITE OFFSETS ////
            for (int i = 0; i < entries.Count; i++)
                wrt.Write(0);

            util.padTo(wrt, 0x20);

            for (int i = 0; i < entries.Count; i++)
                entries[i].writeToStream(wrt);

            var size = (int)wrt.BaseStream.Position;

            wrt.BaseStream.Position = 0;
            wrt.Write(size);

            wrt.BaseStream.Position = 8;
            for (int i = 0; i < entries.Count; i++)
                wrt.Write(entries[i].mOffset);

        }
    }

    internal class cswEntry
    {
        public int mOffset = 0;
        public short Id;
        public string Name = "NO NAME";
        public short Modifier = 0;
        public byte[] Data = new byte[0];
        public int loopStart;
        public int loopEnd;
        public short SampleRate;

        public static cswEntry createFromStream(BeBinaryReader read)
        {
            var bb = new cswEntry();
            bb.readFromStream(read);
            return bb;
        }

        public void readFromStream(BeBinaryReader read)
        {
            mOffset = (int)read.BaseStream.Position;
            var size = read.ReadInt32();
            loopStart = read.ReadInt32();
            loopEnd = read.ReadInt32();
            Data = read.ReadBytes(size);
            util.endianSwapArray(ref Data); // rotate on importing
        }

        public void readBCTDataFromStream(BeBinaryReader read)
        {
            Id = read.ReadInt16();
            SampleRate = read.ReadInt16();
            Modifier = read.ReadInt16();
            read.ReadUInt16(); // Skip 2 bytes;
        }

        public void writeToStream(BeBinaryWriter wrt)
        {
            mOffset = (int)wrt.BaseStream.Position;
            wrt.Write(Data.Length);
            wrt.Write(loopStart);
            wrt.Write(loopEnd);
            util.endianSwapArray(ref Data); // rotate on exporting
            wrt.Write(Data);
            util.endianSwapArray(ref Data); // rotate back
            util.padTo(wrt, 0x20);
        }
    }
}
