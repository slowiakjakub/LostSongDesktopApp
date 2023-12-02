using LostSongDesktopAppBackend;
using LostSongDesktopAppBackend.AudioProcessing;
using LostSongDesktopAppBackend.DataAccess;
using LostSongDesktopAppBackend.Exceptions;
using LostSongDesktopAppBackend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LostSongDesktopApp
{
    public partial class MainWindowForm : Form
    {
        string filePath;

        public MainWindowForm()
        {
            InitializeComponent();
            APIHelper.InitializeClient();
        }

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Audio file|*.mp3;*.wav";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                runMusictagButton.Enabled = true;
                progressStatusLabel.ForeColor = Color.FromArgb(237, 237, 237);
                progressStatusLabel.Text = $"Loaded file: {Path.GetFileName(filePath)}";
            }
        }

        private async void runMusictagButton_Click(object sender, EventArgs e)
        {
            progressStatusLabel.Text = "Running MusicTag...";
            runMusictagButton.Enabled = false;
            bool exception = false;
            string songName = "";
            try
            {
                MusicRecognizer recognizer = new MusicRecognizer(Factory.CreateFileTagger());
                await recognizer.RunMusicTagForAudioFileAsync(filePath);
                songName = recognizer.RecognizedSongName;
            }
            catch (AudioTooShortException)
            {
                MessageBoxAudioTooShort();
                exception = true;
            }
            catch (Exception ex) when ((ex is InvalidOperationException) || (ex is InvalidDataException))
            {
                MessageBoxProblemProcessing(ex);
                exception = true;
            }
            catch (HttpRequestException ex)
            {
                MessageBoxConnectionFailed(ex);
                exception = true;
            }
            catch (ResultsArrayEmptyException)
            {
                MessageBoxCannotRecognizeSong();
                exception = true;
            }
            if (!exception)
            {
                ProgressLabelSuccess(songName);
                MessageBoxSuccess();
            }
            else ProgressLabelFailure();
        }

        private void MessageBoxAudioTooShort()
        {
            MessageBox.Show($"Your audio file is too short!{Environment.NewLine}" +
            "It should be 30 seconds minimum!",
            "Invalid file", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }
        private void MessageBoxProblemProcessing(Exception ex)
        {
            MessageBox.Show("There was a problem processing your file."
                + Environment.NewLine +
                "Error Info: "
                + ex.Message,
                "Invalid file",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void MessageBoxConnectionFailed(HttpRequestException ex)
        {
            MessageBox.Show("Connection to AcousticID API failed: "
                + Environment.NewLine
                + ex.Message, "Connection problem",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void MessageBoxCannotRecognizeSong()
        {
            MessageBox.Show("Cannot recognize a song.",
                "No results",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void MessageBoxSuccess()
        {
            MessageBox.Show("Your file was sucesfully recognized and renamed!",
                "Tagging succesful!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void ProgressLabelSuccess(string songName)
        {
            progressStatusLabel.ForeColor = Color.FromArgb(7, 255, 32);
            progressStatusLabel.Text = $"Recognized song: {songName}!";
        }
        private void ProgressLabelFailure()
        {
            progressStatusLabel.ForeColor = Color.FromArgb(255, 7, 7);
            progressStatusLabel.Text = "Failure: Try to load different file";
        }
    }
}
