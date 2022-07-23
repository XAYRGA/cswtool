using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Be.IO;


namespace cswtool
{
   public static class util
    {
        public static int[] readInt32Array(BeBinaryReader binStream, int count)
        {
            var b = new int[count];
            for (int i = 0; i < count; i++)
                b[i] = binStream.ReadInt32();
            return b;
        }
        public static void endianSwapArray(ref byte[] data)
        {
            for (int i=0; i < data.Length; i+=2)
            {
                var od = data[i];
                data[i] = data[i + 1];
                data[i + 1] = od;
            }
        }
        public static short[] pcm16ByteToShort(byte[] data)
        {
            short[] pcm16 = new short[data.Length / 2];
            for (int i=0; i < data.Length;i+=2) 
                pcm16[i/2] = (short)(data[i + 1] << 8 | data[i]);
            return pcm16;
        }

        public static byte[] pcm16ShortToByte(short[] data)
        {
            byte[] outdata = new byte[data.Length * 2];
            for (int i = 0; i < data.Length; i ++)
            {
                outdata[i * 2] = (byte)((data[i]) & 0xFF);
                outdata[i * 2 + 1] = (byte)((data[i] >> 8) & 0xFF);
            }
            return outdata;
        }

        public static int padToInt(int Addr, int padding)
        {
            var delta = (int)(Addr % padding);
            return (padding - delta);
        }

        public static int padTo(BeBinaryWriter bw, int padding)
        {
            var pp = padToInt((int)bw.BaseStream.Position, padding);
            bw.Write(new byte[pp]);
            return pp;
        }


    }
}
