using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace TextToSpeech
{
    public partial class TextToSpeechForm : Form
    {
        public TextToSpeechForm()
        {
            InitializeComponent();

            //fill speaker settings
            List<VoiceInfo> infos = Sprachausgabe.GetInstalledVoices();
            foreach (VoiceInfo info in infos)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = info.Description;
                item.Value = info.Name;
                cbSpeaker.Items.Add(item);
            }

            cbSpeaker.SelectedIndex = 0;
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            string text = rtbText.Text.ToString();
            string speaker = ((ComboboxItem)cbSpeaker.SelectedItem).Value.ToString();
            Sprachausgabe.speak(rtbText.Text.ToString(), speaker);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string text = rtbText.Text.ToString();
            string speakerDescription = ((ComboboxItem)cbSpeaker.SelectedItem).Value.ToString();
            Console.WriteLine(speakerDescription);

            // Displays a SaveFileDialog so the user can save the wave file
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Wave File|*.wav";
            saveFileDialog1.Title = "Save the wave file";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                Sprachausgabe.saveToFile(text, speakerDescription, saveFileDialog1.FileName);
            }
        }


        private class Sprachausgabe
        {
            private static SpeechSynthesizer speaker;

            public static void speak(string text, string speakerDescription)
            {
                speaker.SetOutputToDefaultAudioDevice();
                speaker.SelectVoice(speakerDescription);
                speaker.SpeakAsync(text);
            }

            public static void saveToFile(string text, string speakerDescription, string path)
            {
                speaker.SetOutputToWaveFile(path);
                speaker.SelectVoice(speakerDescription);
                speaker.SpeakAsync(text);
            }

            public static List<VoiceInfo> GetInstalledVoices()
            {
                speaker = new SpeechSynthesizer();
                speaker.SetOutputToDefaultAudioDevice();
                speaker.Rate = 1;
                speaker.Volume = 100;

                var listOfVoiceInfo = from voice
                                      in speaker.GetInstalledVoices()
                                      select voice.VoiceInfo;
                return listOfVoiceInfo.ToList<VoiceInfo>();
            }
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}
