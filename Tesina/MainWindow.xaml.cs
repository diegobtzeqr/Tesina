using System;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using Microsoft.Kinect;
using Microsoft.Kinect.Toolkit;

namespace Tesina
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Volume level constant, range is 0 - 1.
        private static double volumeLevel = 1.0;

        // Kinect sensor
        private KinectSensor sensor;

        // Files with the piano note sound
        private static string currDir = AppDomain.CurrentDomain.BaseDirectory;
        private static Uri solfeggioUri = new Uri(currDir + @"..\..\sounds\solfeggio-528.mp3");
        private static Uri nt01Uri = new Uri(currDir + @"..\..\sounds\a49.wav");
        private static Uri nt02Uri = new Uri(currDir + @"..\..\sounds\b49.wav");
        private static Uri nt03Uri = new Uri(currDir + @"..\..\sounds\a50.wav");
        private static Uri nt04Uri = new Uri(currDir + @"..\..\sounds\b50.wav");
        private static Uri nt05Uri = new Uri(currDir + @"..\..\sounds\a51.wav");
        private static Uri nt06Uri = new Uri(currDir + @"..\..\sounds\a52.wav");
        private static Uri nt07Uri = new Uri(currDir + @"..\..\sounds\b52.wav");
        private static Uri nt08Uri = new Uri(currDir + @"..\..\sounds\a53.wav");
        private static Uri nt09Uri = new Uri(currDir + @"..\..\sounds\b53.wav");
        private static Uri nt10Uri = new Uri(currDir + @"..\..\sounds\a54.wav");
        private static Uri nt11Uri = new Uri(currDir + @"..\..\sounds\b54.wav");
        private static Uri nt12Uri = new Uri(currDir + @"..\..\sounds\a55.wav");
        private static Uri nt13Uri = new Uri(currDir + @"..\..\sounds\a56.wav");
        private static Uri nt14Uri = new Uri(currDir + @"..\..\sounds\b56.wav");
        private static Uri nt15Uri = new Uri(currDir + @"..\..\sounds\a57.wav");
        private static Uri nt16Uri = new Uri(currDir + @"..\..\sounds\a48.wav");
        private static Uri nt17Uri = new Uri(currDir + @"..\..\sounds\a81.wav");
        private static Uri nt18Uri = new Uri(currDir + @"..\..\sounds\b81.wav");
        private static Uri nt19Uri = new Uri(currDir + @"..\..\sounds\a87.wav");
        private static Uri nt20Uri = new Uri(currDir + @"..\..\sounds\b87.wav");
        private static Uri nt21Uri = new Uri(currDir + @"..\..\sounds\a69.wav");
        private static Uri nt22Uri = new Uri(currDir + @"..\..\sounds\b69.wav");
        private static Uri nt23Uri = new Uri(currDir + @"..\..\sounds\a82.wav");
        private static Uri nt24Uri = new Uri(currDir + @"..\..\sounds\a84.wav");
        private static Uri nt25Uri = new Uri(currDir + @"..\..\sounds\b84.wav");
        private static Uri nt26Uri = new Uri(currDir + @"..\..\sounds\a89.wav");
        private static Uri nt27Uri = new Uri(currDir + @"..\..\sounds\b89.wav");
        private static Uri nt28Uri = new Uri(currDir + @"..\..\sounds\a85.wav");
        private static Uri nt29Uri = new Uri(currDir + @"..\..\sounds\a73.wav");
        private static Uri nt30Uri = new Uri(currDir + @"..\..\sounds\b73.wav");
        private static Uri nt31Uri = new Uri(currDir + @"..\..\sounds\a79.wav");
        private static Uri nt32Uri = new Uri(currDir + @"..\..\sounds\b79.wav");
        private static Uri nt33Uri = new Uri(currDir + @"..\..\sounds\a80.wav");
        private static Uri nt34Uri = new Uri(currDir + @"..\..\sounds\b80.wav");
        private static Uri nt35Uri = new Uri(currDir + @"..\..\sounds\a65.wav");
        private static Uri nt36Uri = new Uri(currDir + @"..\..\sounds\a83.wav");
        private static Uri nt37Uri = new Uri(currDir + @"..\..\sounds\b83.wav");
        private static Uri nt38Uri = new Uri(currDir + @"..\..\sounds\a68.wav");
        private static Uri nt39Uri = new Uri(currDir + @"..\..\sounds\b68.wav");
        private static Uri nt40Uri = new Uri(currDir + @"..\..\sounds\a70.wav");
        private static Uri nt41Uri = new Uri(currDir + @"..\..\sounds\a71.wav");
        private static Uri nt42Uri = new Uri(currDir + @"..\..\sounds\b71.wav");
        private static Uri nt43Uri = new Uri(currDir + @"..\..\sounds\a72.wav");
        private static Uri nt44Uri = new Uri(currDir + @"..\..\sounds\b72.wav");
        private static Uri nt45Uri = new Uri(currDir + @"..\..\sounds\a74.wav");
        private static Uri nt46Uri = new Uri(currDir + @"..\..\sounds\b74.wav");
        private static Uri nt47Uri = new Uri(currDir + @"..\..\sounds\a75.wav");
        private static Uri nt48Uri = new Uri(currDir + @"..\..\sounds\a76.wav");
        
        // Media player for each note.
        private MediaPlayer solfeggio = new MediaPlayer();
        private MediaPlayer nt01 = new MediaPlayer();
        private MediaPlayer nt02 = new MediaPlayer();
        private MediaPlayer nt03 = new MediaPlayer();
        private MediaPlayer nt04 = new MediaPlayer();
        private MediaPlayer nt05 = new MediaPlayer();
        private MediaPlayer nt06 = new MediaPlayer();
        private MediaPlayer nt07 = new MediaPlayer();
        private MediaPlayer nt08 = new MediaPlayer();
        private MediaPlayer nt09 = new MediaPlayer();
        private MediaPlayer nt10 = new MediaPlayer();
        private MediaPlayer nt11 = new MediaPlayer();
        private MediaPlayer nt12 = new MediaPlayer();
        private MediaPlayer nt13 = new MediaPlayer();
        private MediaPlayer nt14 = new MediaPlayer();
        private MediaPlayer nt15 = new MediaPlayer();
        private MediaPlayer nt16 = new MediaPlayer();
        private MediaPlayer nt17 = new MediaPlayer();
        private MediaPlayer nt18 = new MediaPlayer();
        private MediaPlayer nt19 = new MediaPlayer();
        private MediaPlayer nt20 = new MediaPlayer();
        private MediaPlayer nt21 = new MediaPlayer();
        private MediaPlayer nt22 = new MediaPlayer();
        private MediaPlayer nt23 = new MediaPlayer();
        private MediaPlayer nt24 = new MediaPlayer();
        private MediaPlayer nt25 = new MediaPlayer();
        private MediaPlayer nt26 = new MediaPlayer();
        private MediaPlayer nt27 = new MediaPlayer();
        private MediaPlayer nt28 = new MediaPlayer();
        private MediaPlayer nt29 = new MediaPlayer();
        private MediaPlayer nt30 = new MediaPlayer();
        private MediaPlayer nt31 = new MediaPlayer();
        private MediaPlayer nt32 = new MediaPlayer();
        private MediaPlayer nt33 = new MediaPlayer();
        private MediaPlayer nt34 = new MediaPlayer();
        private MediaPlayer nt35 = new MediaPlayer();
        private MediaPlayer nt36 = new MediaPlayer();
        private MediaPlayer nt37 = new MediaPlayer();
        private MediaPlayer nt38 = new MediaPlayer();
        private MediaPlayer nt39 = new MediaPlayer();
        private MediaPlayer nt40 = new MediaPlayer();
        private MediaPlayer nt41 = new MediaPlayer();
        private MediaPlayer nt42 = new MediaPlayer();
        private MediaPlayer nt43 = new MediaPlayer();
        private MediaPlayer nt44 = new MediaPlayer();
        private MediaPlayer nt45 = new MediaPlayer();
        private MediaPlayer nt46 = new MediaPlayer();
        private MediaPlayer nt47 = new MediaPlayer();
        private MediaPlayer nt48 = new MediaPlayer();

        // Flags for each note, to know if that note has finished playing
        private bool solfeggioFinished = true;
        private bool nt01Finished = true;
        private bool nt02Finished = true;
        private bool nt03Finished = true;
        private bool nt04Finished = true;
        private bool nt05Finished = true;
        private bool nt06Finished = true;
        private bool nt07Finished = true;
        private bool nt08Finished = true;
        private bool nt09Finished = true;
        private bool nt10Finished = true;
        private bool nt11Finished = true;
        private bool nt12Finished = true;
        private bool nt13Finished = true;
        private bool nt14Finished = true;
        private bool nt15Finished = true;
        private bool nt16Finished = true;
        private bool nt17Finished = true;
        private bool nt18Finished = true;
        private bool nt19Finished = true;
        private bool nt20Finished = true;
        private bool nt21Finished = true;
        private bool nt22Finished = true;
        private bool nt23Finished = true;
        private bool nt24Finished = true;
        private bool nt25Finished = true;
        private bool nt26Finished = true;
        private bool nt27Finished = true;
        private bool nt28Finished = true;
        private bool nt29Finished = true;
        private bool nt30Finished = true;
        private bool nt31Finished = true;
        private bool nt32Finished = true;
        private bool nt33Finished = true;
        private bool nt34Finished = true;
        private bool nt35Finished = true;
        private bool nt36Finished = true;
        private bool nt37Finished = true;
        private bool nt38Finished = true;
        private bool nt39Finished = true;
        private bool nt40Finished = true;
        private bool nt41Finished = true;
        private bool nt42Finished = true;
        private bool nt43Finished = true;
        private bool nt44Finished = true;
        private bool nt45Finished = true;
        private bool nt46Finished = true;
        private bool nt47Finished = true;
        private bool nt48Finished = true;

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindowLoaded;

            // Set max volume to each media player (the range is 0 - 1)
            solfeggio.Volume = volumeLevel;
            nt01.Volume = volumeLevel;
            nt02.Volume = volumeLevel;
            nt03.Volume = volumeLevel;
            nt04.Volume = volumeLevel;
            nt05.Volume = volumeLevel;
            nt06.Volume = volumeLevel;
            nt07.Volume = volumeLevel;
            nt08.Volume = volumeLevel;
            nt09.Volume = volumeLevel;
            nt10.Volume = volumeLevel;
            nt11.Volume = volumeLevel;
            nt12.Volume = volumeLevel;
            nt13.Volume = volumeLevel;
            nt14.Volume = volumeLevel;
            nt15.Volume = volumeLevel;
            nt16.Volume = volumeLevel;
            nt17.Volume = volumeLevel;
            nt18.Volume = volumeLevel;
            nt19.Volume = volumeLevel;
            nt20.Volume = volumeLevel;
            nt21.Volume = volumeLevel;
            nt22.Volume = volumeLevel;
            nt23.Volume = volumeLevel;
            nt24.Volume = volumeLevel;
            nt25.Volume = volumeLevel;
            nt26.Volume = volumeLevel;
            nt27.Volume = volumeLevel;
            nt28.Volume = volumeLevel;
            nt29.Volume = volumeLevel;
            nt30.Volume = volumeLevel;
            nt31.Volume = volumeLevel;
            nt32.Volume = volumeLevel;
            nt33.Volume = volumeLevel;
            nt34.Volume = volumeLevel;
            nt35.Volume = volumeLevel;
            nt36.Volume = volumeLevel;
            nt37.Volume = volumeLevel;
            nt38.Volume = volumeLevel;
            nt39.Volume = volumeLevel;
            nt40.Volume = volumeLevel;
            nt41.Volume = volumeLevel;
            nt42.Volume = volumeLevel;
            nt43.Volume = volumeLevel;
            nt44.Volume = volumeLevel;
            nt45.Volume = volumeLevel;
            nt46.Volume = volumeLevel;
            nt47.Volume = volumeLevel;
            nt48.Volume = volumeLevel;
        }

        private void MainWindowLoaded(object sender, RoutedEventArgs e)
        {
            var sensorStatus = new KinectSensorChooser();
            sensorStatus.KinectChanged += KinectSensorChooserKinectChanged;
            kinectChooser.KinectSensorChooser = sensorStatus;
            sensorStatus.Start();
        }

        private void KinectSensorChooserKinectChanged(object sender, KinectChangedEventArgs e)
        {
            if (sensor != null)
            {
                sensor.SkeletonFrameReady -= KinectSkeletonFrameReady;
            }

            sensor = e.NewSensor;

            if (sensor == null)
            {
                return;
            }

            switch (Convert.ToString(e.NewSensor.Status))
            {
                case "Connected":
                    KinectStatus.Content = "Connected";
                    break;
                case "Disconnected":
                    KinectStatus.Content = "Disconnected";
                    break;
                case "Error":
                    KinectStatus.Content = "Error";
                    break;
                case "NotReady":
                    KinectStatus.Content = "Not Ready";
                    break;
                case "NotPowered":
                    KinectStatus.Content = "Not Powered";
                    break;
                case "Initializing":
                    KinectStatus.Content = "Initialising";
                    break;
                default:
                    KinectStatus.Content = "Undefined";
                    break;
            }

            sensor.SkeletonStream.Enable();
            sensor.SkeletonFrameReady += KinectSkeletonFrameReady;
        }

        private void KinectSkeletonFrameReady(object sender, SkeletonFrameReadyEventArgs e)
        {
            var skeletons = new Skeleton[0];

            using (var skeletonFrame = e.OpenSkeletonFrame())
            {
                if (skeletonFrame != null)
                {
                    skeletons = new Skeleton[skeletonFrame.SkeletonArrayLength];
                    skeletonFrame.CopySkeletonDataTo(skeletons);
                }
            }

            if (skeletons.Length == 0) 
            {
                return;
            }

            var skel = skeletons.FirstOrDefault(x => x.TrackingState == SkeletonTrackingState.Tracked);

            if (skel != null)
            {
                if (solfeggioFinished)
                {
                    solfeggioFinished = false;
                    this.Dispatcher.Invoke(() =>
                    {
                        solfeggio.Open(solfeggioUri);
                        solfeggio.Play();
                        solfeggio.MediaEnded += delegate { solfeggio.Position = new TimeSpan(0); };
                    });
                }
            }
            else
            {
                solfeggioFinished = true;
                this.Dispatcher.Invoke(() =>
                {
                    solfeggio.Stop();
                    nt01.Stop();
                    nt02.Stop();
                    nt03.Stop();
                    nt04.Stop();
                    nt05.Stop();
                    nt06.Stop();
                    nt07.Stop();
                    nt08.Stop();
                    nt09.Stop();
                    nt10.Stop();
                    nt11.Stop();
                    nt12.Stop();
                    nt13.Stop();
                    nt14.Stop();
                    nt15.Stop();
                    nt16.Stop();
                    nt17.Stop();
                    nt18.Stop();
                    nt19.Stop();
                    nt20.Stop();
                    nt21.Stop();
                    nt22.Stop();
                    nt23.Stop();
                    nt24.Stop();
                    nt25.Stop();
                    nt26.Stop();
                    nt27.Stop();
                    nt28.Stop();
                    nt29.Stop();
                    nt30.Stop();
                    nt31.Stop();
                    nt32.Stop();
                    nt33.Stop();
                    nt34.Stop();
                    nt35.Stop();
                    nt36.Stop();
                    nt37.Stop();
                    nt38.Stop();
                    nt39.Stop();
                    nt40.Stop();
                    nt41.Stop();
                    nt42.Stop();
                    nt43.Stop();
                    nt44.Stop();
                    nt45.Stop();
                    nt46.Stop();
                    nt47.Stop();
                    nt48.Stop();
                });

                return;
            }

            var rightHand = skel.Joints[JointType.WristRight];
            var rightShoulder = skel.Joints[JointType.ShoulderRight];
            var rightHip = skel.Joints[JointType.HipRight];
            var rightAnkle = skel.Joints[JointType.AnkleRight];

            var leftHand = skel.Joints[JointType.WristLeft];
            var leftShoulder = skel.Joints[JointType.ShoulderLeft];
            var leftHip = skel.Joints[JointType.HipLeft];
            var leftAnkle = skel.Joints[JointType.AnkleLeft];

            var leftArmDistToHipY = Math.Abs(leftHand.Position.Y - leftHip.Position.Y);
            var rightArmDistToHipY = Math.Abs(rightHand.Position.Y - rightHip.Position.Y);

            if (leftArmDistToHipY > 0.8 || rightArmDistToHipY > 0.8)
            {
                if (nt48Finished)
                {
                    nt48Finished = false;
                    this.Dispatcher.Invoke(() =>
                    {
                        nt48.Open(nt48Uri);
                        nt48.Play();
                        nt48.MediaEnded += delegate { nt48Finished = true; };
                    });
                }
            }
            else if (leftArmDistToHipY < 0.1 || rightArmDistToHipY < 0.1)
            {
                if (nt13Finished)
                {
                    nt13Finished = false;
                    this.Dispatcher.Invoke(() =>
                    {
                        nt13.Open(nt13Uri);
                        nt13.Play();
                        nt13.MediaEnded += delegate { nt13Finished = true; };
                    });
                }
            }

            soundsLeftArm(Math.Abs(leftHand.Position.X - leftShoulder.Position.X), Math.Abs(leftHand.Position.Z - leftShoulder.Position.Z), leftArmDistToHipY);
            soundsRightArm(Math.Abs(rightHand.Position.X - rightShoulder.Position.X), Math.Abs(rightHand.Position.Z - rightShoulder.Position.Z), rightArmDistToHipY);
            soundsLeftLeg(Math.Abs(leftAnkle.Position.X - leftHip.Position.X), Math.Abs(leftAnkle.Position.Y - leftHip.Position.Y));
            soundsRightLeg(Math.Abs(rightAnkle.Position.X - rightHip.Position.X), Math.Abs(rightAnkle.Position.Y - rightHip.Position.Y));
        }

        private void soundsLeftArm(float distToShoulderX, float distToShoulderZ, float distToHipY)
        {
            /*XValueLeftWristToShoulder.Text = distToShoulderX.ToString(CultureInfo.InvariantCulture).Substring(0,5);
            ZValueLeftWristToShoulder.Text = distToShoulderZ.ToString(CultureInfo.InvariantCulture).Substring(0,5);
            YValueLeftWristToHip.Text = distToHipY.ToString(CultureInfo.InvariantCulture).Substring(0,5);*/

            if (distToHipY > 0.6)
            {
                if (distToShoulderZ < 0.25)
                {
                    if (distToShoulderX < 0.16)
                    {
                        if (nt46Finished)
                        {
                            nt46Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt46.Open(nt46Uri);
                                nt46.Play();
                                nt46.MediaEnded += delegate { nt46Finished = true; };
                            });
                        }
                    }
                    else if (distToShoulderX < 0.32)
                    {
                        if (nt44Finished)
                        {
                            nt44Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt44.Open(nt44Uri);
                                nt44.Play();
                                nt44.MediaEnded += delegate { nt44Finished = true; };
                            });
                        }
                    }
                    else
                    {
                        if (nt42Finished)
                        {
                            nt42Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt42.Open(nt42Uri);
                                nt42.Play();
                                nt42.MediaEnded += delegate { nt42Finished = true; };
                            });
                        }
                    }
                }
                else
                {
                    if (distToShoulderX < 0.25)
                    {
                        if (nt40Finished)
                        {
                            nt40Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt40.Open(nt40Uri);
                                nt40.Play();
                                nt40.MediaEnded += delegate { nt40Finished = true; };
                            });
                        }
                    }
                    else
                    {
                        if (nt38Finished)
                        {
                            nt38Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt38.Open(nt38Uri);
                                nt38.Play();
                                nt38.MediaEnded += delegate { nt38Finished = true; };
                            });
                        }
                    }
                }
            }
            else if (distToHipY > 0.3)
            {
                if (distToShoulderZ < 0.25)
                {
                    if (distToShoulderX < 0.175)
                    {
                        if (nt36Finished)
                        {
                            nt36Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt36.Open(nt36Uri);
                                nt36.Play();
                                nt36.MediaEnded += delegate { nt36Finished = true; };
                            });
                        }
                    }
                    else if (distToShoulderX < 0.35)
                    {
                        if (nt34Finished)
                        {
                            nt34Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt34.Open(nt34Uri);
                                nt34.Play();
                                nt34.MediaEnded += delegate { nt34Finished = true; };
                            });
                        }
                    }
                    else
                    {
                        if (nt32Finished)
                        {
                            nt32Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt32.Open(nt32Uri);
                                nt32.Play();
                                nt32.MediaEnded += delegate { nt32Finished = true; };
                            });
                        }
                    }
                }
                else if (distToShoulderZ < 0.42)
                {
                    if (distToShoulderX < 0.175)
                    {
                        if (nt30Finished)
                        {
                            nt30Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt30.Open(nt30Uri);
                                nt30.Play();
                                nt30.MediaEnded += delegate { nt30Finished = true; };
                            });
                        }
                    }
                    else if (distToShoulderX < 0.35)
                    {
                        if (nt28Finished)
                        {
                            nt28Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt28.Open(nt28Uri);
                                nt28.Play();
                                nt28.MediaEnded += delegate { nt28Finished = true; };
                            });
                        }
                    }
                    else
                    {
                        if (nt26Finished)
                        {
                            nt26Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt26.Open(nt26Uri);
                                nt26.Play();
                                nt26.MediaEnded += delegate { nt26Finished = true; };
                            });
                        }
                    }
                }
                else
                {
                    if (nt24Finished)
                    {
                        nt24Finished = false;
                        this.Dispatcher.Invoke(() =>
                        {
                            nt24.Open(nt24Uri);
                            nt24.Play();
                            nt24.MediaEnded += delegate { nt24Finished = true; };
                        });
                    }
                }
            }
            else
            {
                if (distToShoulderZ < 0.25)
                {
                    if (distToShoulderX < 0.175)
                    {
                        if (nt22Finished)
                        {
                            nt22Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt22.Open(nt22Uri);
                                nt22.Play();
                                nt22.MediaEnded += delegate { nt22Finished = true; };
                            });
                        }
                    }
                    else if (distToShoulderX < 0.35)
                    {
                        if (nt20Finished)
                        {
                            nt20Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt20.Open(nt20Uri);
                                nt20.Play();
                                nt20.MediaEnded += delegate { nt20Finished = true; };
                            });
                        }
                    }
                    else
                    {
                        if (nt18Finished)
                        {
                            nt18Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt18.Open(nt18Uri);
                                nt18.Play();
                                nt18.MediaEnded += delegate { nt18Finished = true; };
                            });
                        }
                    }
                }
                else
                {
                    if (distToShoulderX < 0.25)
                    {
                        if (nt16Finished)
                        {
                            nt16Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt16.Open(nt16Uri);
                                nt16.Play();
                                nt16.MediaEnded += delegate { nt16Finished = true; };
                            });
                        }
                    }
                    else
                    {
                        if (nt14Finished)
                        {
                            nt14Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt14.Open(nt14Uri);
                                nt14.Play();
                                nt14.MediaEnded += delegate { nt14Finished = true; };
                            });
                        }
                    }
                }
            }
        }

        private void soundsRightArm(float distToShoulderX, float distToShoulderZ, float distToHipY)
        {
            /*XValueRightWristToShoulder.Text = distToShoulderX.ToString(CultureInfo.InvariantCulture).Substring(0,5);
            ZValueRightWristToShoulder.Text = distToShoulderZ.ToString(CultureInfo.InvariantCulture).Substring(0,5);
            YValueRightWristToHip.Text = distToHipY.ToString(CultureInfo.InvariantCulture).Substring(0,5);*/

            if (distToHipY > 0.6)
            {
                if (distToShoulderZ < 0.25)
                {
                    if (distToShoulderX < 0.16)
                    {
                        if (nt47Finished)
                        {
                            nt47Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt47.Open(nt47Uri);
                                nt47.Play();
                                nt47.MediaEnded += delegate { nt47Finished = true; };
                            });
                        }
                    }
                    else if (distToShoulderX < 0.32)
                    {
                        if (nt45Finished)
                        {
                            nt45Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt45.Open(nt45Uri);
                                nt45.Play();
                                nt45.MediaEnded += delegate { nt45Finished = true; };
                            });
                        }
                    }
                    else
                    {
                        if (nt43Finished)
                        {
                            nt43Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt43.Open(nt43Uri);
                                nt43.Play();
                                nt43.MediaEnded += delegate { nt43Finished = true; };
                            });
                        }
                    }
                }
                else
                {
                    if (distToShoulderX < 0.25)
                    {
                        if (nt41Finished)
                        {
                            nt41Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt41.Open(nt41Uri);
                                nt41.Play();
                                nt41.MediaEnded += delegate { nt41Finished = true; };
                            });
                        }
                        
                    }
                    else
                    {
                        if (nt39Finished)
                        {
                            nt39Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt39.Open(nt39Uri);
                                nt39.Play();
                                nt39.MediaEnded += delegate { nt39Finished = true; };
                            });
                        }
                    }
                }
            }
            else if (distToHipY > 0.3)
            {
                if (distToShoulderZ < 0.25)
                {
                    if (distToShoulderX < 0.175)
                    {
                        if (nt37Finished)
                        {
                            nt37Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt37.Open(nt37Uri);
                                nt37.Play();
                                nt37.MediaEnded += delegate { nt37Finished = true; };
                            });
                        }
                    }
                    else if (distToShoulderX < 0.35)
                    {
                        if (nt35Finished)
                        {
                            nt35Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt35.Open(nt35Uri);
                                nt35.Play();
                                nt35.MediaEnded += delegate { nt35Finished = true; };
                            });
                        }
                    }
                    else
                    {
                        if (nt33Finished)
                        {
                            nt33Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt33.Open(nt33Uri);
                                nt33.Play();
                                nt33.MediaEnded += delegate { nt33Finished = true; };
                            });
                        }
                    }
                }
                else if (distToShoulderZ < 0.42)
                {
                    if (distToShoulderX < 0.175)
                    {
                        if (nt31Finished)
                        {
                            nt31Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt31.Open(nt31Uri);
                                nt31.Play();
                                nt31.MediaEnded += delegate { nt31Finished = true; };
                            });
                        }
                    }
                    else if (distToShoulderX < 0.35)
                    {
                        if (nt29Finished)
                        {
                            nt29Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt29.Open(nt29Uri);
                                nt29.Play();
                                nt29.MediaEnded += delegate { nt29Finished = true; };
                            });
                        }
                    }
                    else
                    {
                        if (nt27Finished)
                        {
                            nt27Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt27.Open(nt27Uri);
                                nt27.Play();
                                nt27.MediaEnded += delegate { nt27Finished = true; };
                            });
                        }
                    }
                }
                else
                {
                    if (nt25Finished)
                    {
                        nt25Finished = false;
                        this.Dispatcher.Invoke(() =>
                        {
                            nt25.Open(nt25Uri);
                            nt25.Play();
                            nt25.MediaEnded += delegate { nt25Finished = true; };
                        });
                    }
                }
            }
            else
            {
                if (distToShoulderZ < 0.25)
                {
                    if (distToShoulderX < 0.175)
                    {
                        if (nt23Finished)
                        {
                            nt23Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt23.Open(nt23Uri);
                                nt23.Play();
                                nt23.MediaEnded += delegate { nt23Finished = true; };
                            });
                        }
                    }
                    else if (distToShoulderX < 0.35)
                    {
                        if (nt21Finished)
                        {
                            nt21Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt21.Open(nt21Uri);
                                nt21.Play();
                                nt21.MediaEnded += delegate { nt21Finished = true; };
                            });
                        }
                    }
                    else
                    {
                        if (nt19Finished)
                        {
                            nt19Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt19.Open(nt19Uri);
                                nt19.Play();
                                nt19.MediaEnded += delegate { nt19Finished = true; };
                            });
                        }
                    }
                }
                else
                {
                    if (distToShoulderX < 0.25)
                    {
                        if (nt17Finished)
                        {
                            nt17Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt17.Open(nt17Uri);
                                nt17.Play();
                                nt17.MediaEnded += delegate { nt17Finished = true; };
                            });
                        }
                    }
                    else
                    {
                        if (nt15Finished)
                        {
                            nt15Finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt15.Open(nt15Uri);
                                nt15.Play();
                                nt15.MediaEnded += delegate { nt15Finished = true; };
                            });
                        }
                    }
                }
            }
        }

        private void soundsLeftLeg(float distToHipX, float distToHipY)
        {
            /*XValueLeftAnkleToHip.Text = distToHipX.ToString(CultureInfo.InvariantCulture).Substring(0,5);
            YValueLeftAnkleToHip.Text = distToHipY.ToString(CultureInfo.InvariantCulture).Substring(0,5);*/

            if (distToHipY < 0.4)
            {
                if (distToHipX < 0.18)
                {
                    if (nt12Finished)
                    {
                        nt12Finished = false;
                        this.Dispatcher.Invoke(() =>
                        {
                            nt12.Open(nt12Uri);
                            nt12.Play();
                            nt12.MediaEnded += delegate { nt12Finished = true; };
                        });
                    }
                }
                else if (distToHipX < 0.36)
                {
                    if (nt10Finished)
                    {
                        nt10Finished = false;
                        this.Dispatcher.Invoke(() =>
                        {
                            nt10.Open(nt10Uri);
                            nt10.Play();
                            nt10.MediaEnded += delegate { nt10Finished = true; };
                        });
                    }
                }
                else
                {
                    if (nt08Finished)
                    {
                        nt08Finished = false;
                        this.Dispatcher.Invoke(() =>
                        {
                            nt08.Open(nt08Uri);
                            nt08.Play();
                            nt08.MediaEnded += delegate { nt08Finished = true; };
                        });
                    }
                }
            }
            else if (distToHipY <= 0.5)
            {
                if (distToHipX < 0.18)
                {
                    if (nt06Finished)
                    {
                        nt06Finished = false;
                        this.Dispatcher.Invoke(() =>
                        {
                            nt06.Open(nt06Uri);
                            nt06.Play();
                            nt06.MediaEnded += delegate { nt06Finished = true; };
                        });
                    }
                }
                else if (distToHipX < 0.36)
                {
                    if (nt04Finished)
                    {
                        nt04Finished = false;
                        this.Dispatcher.Invoke(() =>
                        {
                            nt04.Open(nt04Uri);
                            nt04.Play();
                            nt04.MediaEnded += delegate { nt04Finished = true; };
                        });
                    }
                }
                else
                {
                    if (nt02Finished)
                    {
                        nt02Finished = false;
                        this.Dispatcher.Invoke(() =>
                        {
                            nt02.Open(nt02Uri);
                            nt02.Play();
                            nt02.MediaEnded += delegate { nt02Finished = true; };
                        });
                    }
                }
            }
        }

        private void soundsRightLeg(float distToHipX, float distToHipY)
        {
            /*XValueRightAnkleToHip.Text = distToHipX.ToString(CultureInfo.InvariantCulture).Substring(0,5);
            YValueRightAnkleToHip.Text = distToHipY.ToString(CultureInfo.InvariantCulture).Substring(0,5);*/

            if (distToHipY < 0.4)
            {
                if (distToHipX < 0.18)
                {
                    if (nt11Finished)
                    {
                        nt11Finished = false;
                        this.Dispatcher.Invoke(() =>
                        {
                            nt11.Open(nt11Uri);
                            nt11.Play();
                            nt11.MediaEnded += delegate { nt11Finished = true; };
                        });
                    }
                }
                else if (distToHipX < 0.36)
                {
                    if (nt09Finished)
                    {
                        nt09Finished = false;
                        this.Dispatcher.Invoke(() =>
                        {
                            nt09.Open(nt09Uri);
                            nt09.Play();
                            nt09.MediaEnded += delegate { nt09Finished = true; };
                        });
                    }
                }
                else
                {
                    if (nt07Finished)
                    {
                        nt07Finished = false;
                        this.Dispatcher.Invoke(() =>
                        {
                            nt07.Open(nt07Uri);
                            nt07.Play();
                            nt07.MediaEnded += delegate { nt07Finished = true; };
                        });
                    }
                }
            }
            else if (distToHipY <= 0.5)
            {
                if (distToHipX < 0.18)
                {
                    if (nt05Finished)
                    {
                        nt05Finished = false;
                        this.Dispatcher.Invoke(() =>
                        {
                            nt05.Open(nt05Uri);
                            nt05.Play();
                            nt05.MediaEnded += delegate { nt05Finished = true; };
                        });
                    }
                }
                else if (distToHipX < 0.36)
                {
                    if (nt03Finished)
                    {
                        nt03Finished = false;
                        this.Dispatcher.Invoke(() =>
                        {
                            nt03.Open(nt03Uri);
                            nt03.Play();
                            nt03.MediaEnded += delegate { nt03Finished = true; };
                        });
                    }
                }
                else
                {
                    if (nt01Finished)
                    {
                        nt01Finished = false;
                        this.Dispatcher.Invoke(() =>
                        {
                            nt01.Open(nt01Uri);
                            nt01.Play();
                            nt01.MediaEnded += delegate { nt01Finished = true; };
                        });
                    }
                }
            }
        }
    }
}
