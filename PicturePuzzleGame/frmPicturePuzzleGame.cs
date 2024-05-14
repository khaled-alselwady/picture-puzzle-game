using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PicturePuzzleGame
{
    public partial class frmPicturePuzzleGame : Form
    {
        private readonly TimeSpan _initialTimeGame = new TimeSpan(0, 0, 30);
        private TimeSpan _elapsedTime = TimeSpan.Zero;
        private static Random _random = new Random();
        private byte[] _positingOfImages = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private byte _positionOfBlackImage = 0;
        private ushort _MovesCount = 0;
        private bool _isPaused = false;

        public frmPicturePuzzleGame()
        {
            InitializeComponent();
        }

        private void _ForEachPictureBox(Action<PictureBox> action)
        {
            foreach (var control in gbImages.Controls)
            {
                if (control is PictureBox pb)
                {
                    action?.Invoke(pb);
                }
            }
        }

        private void _RemoveImagesFromPictureBoxes()
        {
            _ForEachPictureBox(pb => pb.ImageLocation = null);
        }

        private string _GetImagePathByPosition(byte position)
        {
            switch (position)
            {
                case 1:
                    return Path.Combine(Application.StartupPath, clsLink.Pic1);

                case 2:
                    return Path.Combine(Application.StartupPath, clsLink.Pic2);

                case 3:
                    return Path.Combine(Application.StartupPath, clsLink.Pic3);

                case 4:
                    return Path.Combine(Application.StartupPath, clsLink.Pic4);

                case 5:
                    return Path.Combine(Application.StartupPath, clsLink.Pic5);

                case 6:
                    return Path.Combine(Application.StartupPath, clsLink.Pic6);

                case 7:
                    return Path.Combine(Application.StartupPath, clsLink.Pic7);

                case 8:
                    return Path.Combine(Application.StartupPath, clsLink.Pic8);

                case 9:
                    return Path.Combine(Application.StartupPath, clsLink.Pic9);
            }

            return null;
        }

        private void _ShufflingImages(byte positionOfImage)
        {
            foreach (var control in gbImages.Controls)
            {
                if (control is PictureBox pb)
                {
                    if (pb.ImageLocation == null)
                    {
                        pb.ImageLocation = _GetImagePathByPosition(positionOfImage);
                        return;
                    }
                }
            }
        }

        private void _ShufflingArray()
        {
            _positingOfImages = _positingOfImages.OrderBy(x => x = (byte)_random.Next(1, 10)).ToArray();
        }

        private void _PerformShufflingImages()
        {
            foreach (byte position in _positingOfImages)
            {
                _ShufflingImages(position);
            }
        }

        private void _ResetImageToBlackBackground(PictureBox pictureBox)
        {
            pictureBox.ImageLocation = clsLink.Black;
        }

        private void _ChangeThePictureToBlackImageByPosition(byte positionOfImage)
        {
            _ForEachPictureBox(pb =>
            {
                if (Convert.ToByte(pb.Tag) == positionOfImage)
                {
                    _ResetImageToBlackBackground(pb);
                    return;
                }
            });
        }

        private void _ChangeImageWhenClicking(PictureBox pictureBox)
        {
            _ForEachPictureBox(pb =>
            {
                if (pb.ImageLocation == clsLink.Black)
                {
                    pb.ImageLocation = pictureBox.ImageLocation;
                    _ResetImageToBlackBackground(pictureBox);
                    return;
                }
            });
        }

        private bool _CheckIsCorrectOrder()
        {
            byte counter = 1;
            foreach (var control in gbImages.Controls)
            {
                if (control is PictureBox pb)
                {
                    if (pb.ImageLocation == clsLink.Black)
                    {
                        _positionOfBlackImage = counter;
                        counter++;
                        continue;
                    }

                    if (pb.ImageLocation != _GetImagePathByPosition(counter))
                    {
                        return false;
                    }

                    counter++;
                }
            }

            _SetRightImageInBlackImage();
            return true;
        }

        private void _SetRightImageInBlackImage()
        {
            _ForEachPictureBox(pb =>
            {
                if (pb.ImageLocation == clsLink.Black)
                {
                    pb.ImageLocation = _GetImagePathByPosition(_positionOfBlackImage);
                }
            });
        }

        private void _CalculateMovesCount()
        {
            _MovesCount++;
            lblMovesCount.Text = _MovesCount.ToString();
        }

        private void _MassageWon()
        {
            MessageBox.Show($"Congratulations.. Your cat is happy :)\nTime Elapsed:" +
                $" {_elapsedTime.ToString(@"mm\:ss")}\nTotal Moves: {_MovesCount}", "Times Up");
        }

        private void _MassageLose()
        {
            MessageBox.Show($"Sorry.. Your cat is sad :(\nTime Elapsed:" +
                $" {_elapsedTime.ToString(@"mm\:ss")}\nTotal Moves: {_MovesCount}", "Times Up");
        }

        private void _UpdateTimerDisplay()
        {
            TimeSpan remainingTime = _initialTimeGame - _elapsedTime;
            lblTimer.Text = remainingTime.ToString(@"mm\:ss"); // Custom format for minutes and seconds
        }

        private void _ChangeColorOfTimerToRedWhenSecondLessThanTen()
        {
            byte remainSeconds = (byte)(_initialTimeGame.Seconds - _elapsedTime.Seconds);

            if (remainSeconds <= 10 && lblTimer.ForeColor != Color.Red)
            {
                lblTimer.ForeColor = Color.Red;
            }
        }

        private void _TogglePictureBoxesEnabledState(bool isEnable)
        {
            _ForEachPictureBox(pb => pb.Enabled = isEnable);
        }

        private void _ResetGameSettings()
        {
            _elapsedTime = TimeSpan.Zero;
            _MovesCount = 0;
            gbImages.Cursor = Cursors.Default;
            gbImages.Enabled = true;
            lblMovesCount.Text = "0";
            btnPause.Text = "Pause";
            btnPause.Enabled = true;
            _isPaused = false;
        }

        private void _StartGame()
        {
            _ResetGameSettings();

            timer1.Start();

            _RemoveImagesFromPictureBoxes();
            _ShufflingArray();
            _PerformShufflingImages();

            _ChangeThePictureToBlackImageByPosition((byte)_random.Next(1, 10));
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            _elapsedTime = _elapsedTime.Add(TimeSpan.FromSeconds(1));
            _UpdateTimerDisplay();

            _ChangeColorOfTimerToRedWhenSecondLessThanTen();

            if (_elapsedTime >= _initialTimeGame)
            {
                timer1.Stop();
                _ShowResult(() => _MassageLose(), false);
            }
        }

        private void _ShowResult(Action massageOfResult, bool EnableStatusOfPictureBoxes)
        {
            massageOfResult?.Invoke();
            _TogglePictureBoxesEnabledState(EnableStatusOfPictureBoxes);
            gbImages.Cursor = Cursors.No;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _StartGame();
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            _StartGame();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            _CalculateMovesCount();

            _ChangeImageWhenClicking(sender as PictureBox);

            if (_CheckIsCorrectOrder())
            {
                timer1.Stop();

                _ShowResult(() => _MassageWon(), false);
                btnPause.Enabled = false;
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (_isPaused)
            {
                timer1.Start();
                _TogglePictureBoxesEnabledState(true);
                btnPause.Text = "Pause";
                _isPaused = false;
                gbImages.Cursor = Cursors.Default;
            }
            else
            {
                timer1.Stop();
                _TogglePictureBoxesEnabledState(false);
                btnPause.Text = "Resume";
                _isPaused = true;
                gbImages.Cursor = Cursors.No;
            }
        }
    }
}
