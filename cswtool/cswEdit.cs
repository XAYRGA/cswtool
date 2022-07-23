using IrrKlang;
using wsysbuilder;

namespace cswtool
{
    public partial class cswEdit : Form
    {


        private csw cswData;
        private List<ISoundSource> Sounds = new List<ISoundSource>();

        public cswEdit()
        {
            InitializeComponent();
        }

        private void bctOpen_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cswOpen.ShowDialog()==DialogResult.OK)
            {
                Program.Engine.RemoveAllSoundSources();
                for (int i = 0; i < Sounds.Count; i++)
                    Sounds[i].Dispose();
                Sounds = new List<ISoundSource>();

                var cswReader = new Be.IO.BeBinaryReader(cswOpen.OpenFile());
                try
                {
                    cswData = csw.createFromStream(cswReader);

                    if (bctOpen.ShowDialog()==DialogResult.OK)
                    {

                        var bctReader = new Be.IO.BeBinaryReader(bctOpen.OpenFile());
                        cswData.readBCTFromStream(bctReader);

                        ///// SETUP SOUND ENGINE /////
                        for (int i = 0; i < cswData.entries.Count; i++)
                        {
                            var snd = cswData.entries[i];
                            AudioFormat caf = new AudioFormat()
                            {
                                ChannelCount = 1,
                                FrameCount = snd.Data.Length / 2,
                                Format = SampleFormat.Signed16Bit,
                                SampleRate = 6000,
                            };
                            var ss = Program.Engine.AddSoundSourceFromPCMData(snd.Data, snd.Name, caf);
                            Sounds.Add(ss);
                            soundList.Items.Add(cswData.entries[i].Name);
                        }
                    }
                    cswReader.Close();
                } catch
                {
                   
                }
                cswReader.Close();
                cswReader.Dispose();
            }
        }

        private void cswEdit_Load(object sender, EventArgs e)
        {
 
            soundNameEdit.TextChanged += SoundNameEdit_TextChanged;
        }

        private void SoundNameEdit_TextChanged(object? sender, EventArgs e)
        {
            if (cswData == null)
                return;

            var iSS = cswData.entries[soundList.SelectedIndex];
            iSS.Name = soundNameEdit.Text;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cswData == null)
                return;

            var iSS = Sounds[soundList.SelectedIndex];

            Program.Engine.Play2D(iSS, false, false, false);

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (cswData == null)
                return;

            if ( wavSaveAs.ShowDialog() == DialogResult.OK)
            {
                var file = wavSaveAs.OpenFile();
                var writer = new BinaryWriter(file);

                var iSS = cswData.entries[soundList.SelectedIndex];

                var bb = new wsysbuilder.PCM16WAV();
                bb.sampleRate = 6000;
                bb.channels = 1;
                bb.buffer = util.pcm16ByteToShort(iSS.Data);
                bb.sampleCount = bb.buffer.Length;
                bb.bitsPerSample = 16;
                bb.blockAlign = 2;
                if (iSS.loopStart != -1)
                {
 
                    bb.sampler.loops = new SampleLoop[1];
                    bb.sampler.loops[0] = new SampleLoop()
                    {
                        dwIdentifier = 0,
                        dwEnd = iSS.loopEnd,
                        dwFraction = 0,
                        dwPlayCount = 0,
                        dwStart = iSS.loopStart,
                        dwType = 0
                    };
                }
                bb.writeStreamLazy(writer);
              
            
                file.Flush();
                file.Close();
            }
      

        }

        private void refreshInfo()
        {
            if (cswData == null)
                return;
            var iSS = cswData.entries[soundList.SelectedIndex];
            soundNameEdit.Text = iSS.Name;
            SoundName.Text = iSS.Name;
            sampleCount.Text = $"{(iSS.Data.Length / 2)} samples.\r\n{iSS.Data.Length} bytes";
            if (iSS.loopStart != -1)
                loopText.Text = $"Loop: START {iSS.loopStart}, END {iSS.loopEnd}";
            else
                loopText.Text = $"Loop: No loop";
            if ((iSS.Data.Length / 2) < 400)
                errorText.Visible = true;
            else
                errorText.Visible = false;
        }

        private void soundList_SelectedIndexChanged(object sender, EventArgs e)
        { 
            refreshInfo();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (cswData == null)
                return;

            soundList.Items.Clear();
            for (int i = 0; i < cswData.entries.Count; i++)
                soundList.Items.Add(cswData.entries[i].Name);
   
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (cswData == null)
                return;
            var iSS = cswData.entries[soundList.SelectedIndex];
            var sound = Sounds[soundList.SelectedIndex];

            if (wavOpen.ShowDialog() != DialogResult.OK)
                return;

            var file = wavOpen.OpenFile();
            var reader = new BinaryReader(file);
            var wav = PCM16WAV.readStream(reader);
            if (wav.channels > 1)
            {
                MessageBox.Show($"WAV has too many channels: {wav.channels} (max: 1)");
                return;
            }
            if (wav.sampleRate > 6000)            
                if (MessageBox.Show("Your WAV's samplerate is > 8000hz\nThis means that it will end up reaaaallllyyyy slloooowwwww when played on real hardware. (you need to downsample)\r\n\r\nWant to continue?","Warning",MessageBoxButtons.OKCancel)!=DialogResult.OK)            
                    return;

            // Remove old sound source from irrklang pool
            Program.Engine.RemoveSoundSource(sound.Name);
            sound.Dispose();


            iSS.Data = util.pcm16ShortToByte(wav.buffer);

            AudioFormat caf = new AudioFormat()
            {
                ChannelCount = 1,
                FrameCount = wav.sampleCount,
                Format = SampleFormat.Signed16Bit,
                SampleRate = 6000,
            };
            var ss = Program.Engine.AddSoundSourceFromPCMData(iSS.Data, iSS.Name, caf);
            Sounds[soundList.SelectedIndex] = ss;
            refreshInfo();
            file.Close();
            
        }

        private void programInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var q = new AboutCreatorWindow();
            q.ShowDialog();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cswSaveAs.ShowDialog() != DialogResult.OK)
                return;

            var bw = new Be.IO.BeBinaryWriter(cswSaveAs.OpenFile());
            cswData.writeToStream(bw);
            bw.Flush();
            bw.Close();

        }

        private void bctSaveAs_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}