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
        private static string currDir = AppDomain.CurrentDomain.BaseDirectory;

        private KinectSensor sensor;
        private MediaPlayer nt1 = new MediaPlayer();
        private MediaPlayer nt2 = new MediaPlayer();
        private MediaPlayer nt3 = new MediaPlayer();
        private MediaPlayer nt4 = new MediaPlayer();
        private MediaPlayer nt5 = new MediaPlayer();
        private MediaPlayer nt6 = new MediaPlayer();
        private MediaPlayer nt7 = new MediaPlayer();
        private MediaPlayer nt8 = new MediaPlayer();
        private MediaPlayer nt9 = new MediaPlayer();
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
        private bool nt1finished = true;
        private bool nt2finished = true;
        private bool nt3finished = true;
        private bool nt4finished = true;
        private bool nt5finished = true;
        private bool nt6finished = true;
        private bool nt7finished = true;
        private bool nt8finished = true;
        private bool nt9finished = true;
        private bool nt10finished = true;
        private bool nt11finished = true;
        private bool nt12finished = true;
        private bool nt13finished = true;
        private bool nt14finished = true;
        private bool nt15finished = true;
        private bool nt16finished = true;
        private bool nt17finished = true;
        private bool nt18finished = true;
        private bool nt19finished = true;
        private bool nt20finished = true;
        private bool nt21finished = true;
        private bool nt22finished = true;
        private bool nt23finished = true;
        private bool nt24finished = true;
        private bool nt25finished = true;
        private bool nt26finished = true;
        private bool nt27finished = true;
        private bool nt28finished = true;
        private bool nt29finished = true;
        private bool nt30finished = true;
        private bool nt31finished = true;
        private bool nt32finished = true;
        private bool nt33finished = true;
        private bool nt34finished = true;
        private bool nt35finished = true;
        private bool nt36finished = true;
        private bool nt37finished = true;
        private bool nt38finished = true;
        private bool nt39finished = true;
        private bool nt40finished = true;
        private bool nt41finished = true;
        private bool nt42finished = true;
        private bool nt43finished = true;
        private bool nt44finished = true;
        private bool nt45finished = true;
        private bool nt46Finished = true;
        private bool nt47Finished = true;

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindowLoaded;
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
                sensor.SkeletonFrameReady -= KinectSkeletonFrameReady;

            sensor = e.NewSensor;

            if (sensor == null)
                return;

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

            if (skeletons.Length == 0) { return; }

            var skel = skeletons.FirstOrDefault(x => x.TrackingState == SkeletonTrackingState.Tracked);

            if (skel == null) { return; }

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
                if (nt47Finished)
                {
                    nt47Finished = false;
                    this.Dispatcher.Invoke(() =>
                    {
                        nt47.Open(new Uri(currDir + @"..\..\sounds\a75.wav"));
                        nt47.Play();
                        nt47.MediaEnded += delegate { nt47Finished = true; };
                    });
                }
            }
            else if (leftArmDistToHipY < 0.1 || rightArmDistToHipY < 0.1)
            {
                if (nt13finished)
                {
                    nt13finished = false;
                    this.Dispatcher.Invoke(() =>
                    {
                        nt13.Open(new Uri(currDir + @"..\..\sounds\a56.wav"));
                        nt13.Play();
                        nt13.MediaEnded += delegate { nt13finished = true; };
                    });
                }
            }

            soundsLeftArm(Math.Abs(leftHand.Position.X - leftShoulder.Position.X), Math.Abs(leftHand.Position.Y - leftShoulder.Position.Y),
                          Math.Abs(leftHand.Position.Z - leftShoulder.Position.Z), leftArmDistToHipY);
            soundsRightArm(Math.Abs(rightHand.Position.X - rightShoulder.Position.X), Math.Abs(rightHand.Position.Y - rightShoulder.Position.Y),
                           Math.Abs(rightHand.Position.Z - rightShoulder.Position.Z), rightArmDistToHipY);
            soundsLeftLeg(Math.Abs(leftAnkle.Position.X - leftHip.Position.X), Math.Abs(leftAnkle.Position.Y - leftHip.Position.Y));
            soundsRightLeg(Math.Abs(rightAnkle.Position.X - rightHip.Position.X), Math.Abs(rightAnkle.Position.Y - rightHip.Position.Y));
        }

        private void soundsLeftArm(float distToShoulderX, float distToShoulderY, float distToShoulderZ, float distToHipY)
        {
            /*XValueLeftWristToShoulder.Text = distToShoulderX.ToString(CultureInfo.InvariantCulture).Substring(0,5);
            YValueLeftWristToShoulder.Text = distToShoulderY.ToString(CultureInfo.InvariantCulture).Substring(0,5);
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
                                nt46.Open(new Uri(currDir + @"..\..\sounds\b74.wav"));
                                nt46.Play();
                                nt46.MediaEnded += delegate { nt46Finished = true; };
                            });
                        }
                    }
                    else if (distToShoulderX < 0.32)
                    {
                        if (nt44finished)
                        {
                            nt44finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt44.Open(new Uri(currDir + @"..\..\sounds\b72.wav"));
                                nt44.Play();
                                nt44.MediaEnded += delegate { nt44finished = true; };
                            });
                        }
                    }
                    else
                    {
                        if (nt42finished)
                        {
                            nt42finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt42.Open(new Uri(currDir + @"..\..\sounds\b71.wav"));
                                nt42.Play();
                                nt42.MediaEnded += delegate { nt42finished = true; };
                            });
                        }
                    }
                }
                else
                {
                    if (distToShoulderX < 0.25)
                    {
                        if (nt40finished)
                        {
                            nt40finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt40.Open(new Uri(currDir + @"..\..\sounds\a70.wav"));
                                nt40.Play();
                                nt40.MediaEnded += delegate { nt40finished = true; };
                            });
                        }
                    }
                    else
                    {
                        if (nt38finished)
                        {
                            nt38finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt38.Open(new Uri(currDir + @"..\..\sounds\a68.wav"));
                                nt38.Play();
                                nt38.MediaEnded += delegate { nt38finished = true; };
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
                        if (nt36finished)
                        {
                            nt36finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt36.Open(new Uri(currDir + @"..\..\sounds\a83.wav"));
                                nt36.Play();
                                nt36.MediaEnded += delegate { nt36finished = true; };
                            });
                        }
                    }
                    else if (distToShoulderX < 0.35)
                    {
                        if (nt34finished)
                        {
                            nt34finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt34.Open(new Uri(currDir + @"..\..\sounds\b80.wav"));
                                nt34.Play();
                                nt34.MediaEnded += delegate { nt34finished = true; };
                            });
                        }
                    }
                    else
                    {
                        if (nt32finished)
                        {
                            nt32finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt32.Open(new Uri(currDir + @"..\..\sounds\b79.wav"));
                                nt32.Play();
                                nt32.MediaEnded += delegate { nt32finished = true; };
                            });
                        }
                    }
                }
                else if (distToShoulderZ < 0.42)
                {
                    if (distToShoulderX < 0.175)
                    {
                        if (nt30finished)
                        {
                            nt30finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt30.Open(new Uri(currDir + @"..\..\sounds\b73.wav"));
                                nt30.Play();
                                nt30.MediaEnded += delegate { nt30finished = true; };
                            });
                        }
                    }
                    else if (distToShoulderX < 0.35)
                    {
                        if (nt28finished)
                        {
                            nt28finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt28.Open(new Uri(currDir + @"..\..\sounds\a85.wav"));
                                nt28.Play();
                                nt28.MediaEnded += delegate { nt28finished = true; };
                            });
                        }
                    }
                    else
                    {
                        if (nt26finished)
                        {
                            nt26finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt26.Open(new Uri(currDir + @"..\..\sounds\a89.wav"));
                                nt26.Play();
                                nt26.MediaEnded += delegate { nt26finished = true; };
                            });
                        }
                    }
                }
                else
                {
                    if (nt24finished)
                    {
                        nt24finished = false;
                        this.Dispatcher.Invoke(() =>
                        {
                            nt24.Open(new Uri(currDir + @"..\..\sounds\a84.wav"));
                            nt24.Play();
                            nt24.MediaEnded += delegate { nt24finished = true; };
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
                        if (nt22finished)
                        {
                            nt22finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt22.Open(new Uri(currDir + @"..\..\sounds\b69.wav"));
                                nt22.Play();
                                nt22.MediaEnded += delegate { nt22finished = true; };
                            });
                        }
                    }
                    else if (distToShoulderX < 0.35)
                    {
                        if (nt20finished)
                        {
                            nt20finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt20.Open(new Uri(currDir + @"..\..\sounds\b87.wav"));
                                nt20.Play();
                                nt20.MediaEnded += delegate { nt20finished = true; };
                            });
                        }
                    }
                    else
                    {
                        if (nt18finished)
                        {
                            nt18finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt18.Open(new Uri(currDir + @"..\..\sounds\b81.wav"));
                                nt18.Play();
                                nt18.MediaEnded += delegate { nt18finished = true; };
                            });
                        }
                    }
                }
                else
                {
                    if (distToShoulderX < 0.25)
                    {
                        if (nt16finished)
                        {
                            nt16finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt16.Open(new Uri(currDir + @"..\..\sounds\a48.wav"));
                                nt16.Play();
                                nt16.MediaEnded += delegate { nt16finished = true; };
                            });
                        }
                    }
                    else
                    {
                        if (nt14finished)
                        {
                            nt14finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt14.Open(new Uri(currDir + @"..\..\sounds\b56.wav"));
                                nt14.Play();
                                nt14.MediaEnded += delegate { nt14finished = true; };
                            });
                        }
                    }
                }
            }
        }

        private void soundsRightArm(float distToShoulderX, float distToShoulderY, float distToShoulderZ, float distToHipY)
        {
            /*XValueRightWristToShoulder.Text = distToShoulderX.ToString(CultureInfo.InvariantCulture).Substring(0,5);
            YValueRightWristToShoulder.Text = distToShoulderY.ToString(CultureInfo.InvariantCulture).Substring(0,5);
            ZValueRightWristToShoulder.Text = distToShoulderZ.ToString(CultureInfo.InvariantCulture).Substring(0,5);
            YValueRightWristToHip.Text = distToHipY.ToString(CultureInfo.InvariantCulture).Substring(0,5);*/

            if (distToHipY > 0.6)
            {
                if (distToShoulderZ < 0.25)
                {
                    if (distToShoulderX < 0.16)
                    {
                        if (nt45finished)
                        {
                            nt45finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt45.Open(new Uri(currDir + @"..\..\sounds\a74.wav"));
                                nt45.Play();
                                nt45.MediaEnded += delegate { nt45finished = true; };
                            });
                        }
                    }
                    else if (distToShoulderX < 0.32)
                    {
                        if (nt43finished)
                        {
                            nt43finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt43.Open(new Uri(currDir + @"..\..\sounds\a72.wav"));
                                nt43.Play();
                                nt43.MediaEnded += delegate { nt43finished = true; };
                            });
                        }
                    }
                    else
                    {
                        if (nt41finished)
                        {
                            nt41finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt41.Open(new Uri(currDir + @"..\..\sounds\a71.wav"));
                                nt41.Play();
                                nt41.MediaEnded += delegate { nt41finished = true; };
                            });
                        }
                    }
                }
                else
                {
                    if (distToShoulderX < 0.25)
                    {
                        if (nt39finished)
                        {
                            nt39finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt39.Open(new Uri(currDir + @"..\..\sounds\b68.wav"));
                                nt39.Play();
                                nt39.MediaEnded += delegate { nt39finished = true; };
                            });
                        }
                    }
                    else
                    {
                        if (nt37finished)
                        {
                            nt37finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt37.Open(new Uri(currDir + @"..\..\sounds\b83.wav"));
                                nt37.Play();
                                nt37.MediaEnded += delegate { nt37finished = true; };
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
                        if (nt35finished)
                        {
                            nt35finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt35.Open(new Uri(currDir + @"..\..\sounds\a65.wav"));
                                nt35.Play();
                                nt35.MediaEnded += delegate { nt35finished = true; };
                            });
                        }
                    }
                    else if (distToShoulderX < 0.35)
                    {
                        if (nt33finished)
                        {
                            nt33finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt33.Open(new Uri(currDir + @"..\..\sounds\a80.wav"));
                                nt33.Play();
                                nt33.MediaEnded += delegate { nt33finished = true; };
                            });
                        }
                    }
                    else
                    {
                        if (nt31finished)
                        {
                            nt31finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt31.Open(new Uri(currDir + @"..\..\sounds\a79.wav"));
                                nt31.Play();
                                nt31.MediaEnded += delegate { nt31finished = true; };
                            });
                        }
                    }
                }
                else if (distToShoulderZ < 0.42)
                {
                    if (distToShoulderX < 0.175)
                    {
                        if (nt29finished)
                        {
                            nt29finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt29.Open(new Uri(currDir + @"..\..\sounds\a73.wav"));
                                nt29.Play();
                                nt29.MediaEnded += delegate { nt29finished = true; };
                            });
                        }
                    }
                    else if (distToShoulderX < 0.35)
                    {
                        if (nt27finished)
                        {
                            nt27finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt27.Open(new Uri(currDir + @"..\..\sounds\b89.wav"));
                                nt27.Play();
                                nt27.MediaEnded += delegate { nt27finished = true; };
                            });
                        }
                    }
                    else
                    {
                        if (nt25finished)
                        {
                            nt25finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt25.Open(new Uri(currDir + @"..\..\sounds\b84.wav"));
                                nt25.Play();
                                nt25.MediaEnded += delegate { nt25finished = true; };
                            });
                        }
                    }
                }
                else
                {
                    if (nt23finished)
                    {
                        nt23finished = false;
                        this.Dispatcher.Invoke(() =>
                        {
                            nt23.Open(new Uri(currDir + @"..\..\sounds\a82.wav"));
                            nt23.Play();
                            nt23.MediaEnded += delegate { nt23finished = true; };
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
                        if (nt21finished)
                        {
                            nt21finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt21.Open(new Uri(currDir + @"..\..\sounds\a69.wav"));
                                nt21.Play();
                                nt21.MediaEnded += delegate { nt21finished = true; };
                            });
                        }
                    }
                    else if (distToShoulderX < 0.35)
                    {
                        if (nt19finished)
                        {
                            nt19finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt19.Open(new Uri(currDir + @"..\..\sounds\a87.wav"));
                                nt19.Play();
                                nt19.MediaEnded += delegate { nt19finished = true; };
                            });
                        }
                    }
                    else
                    {
                        if (nt17finished)
                        {
                            nt17finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt17.Open(new Uri(currDir + @"..\..\sounds\a81.wav"));
                                nt17.Play();
                                nt17.MediaEnded += delegate { nt17finished = true; };
                            });
                        }
                    }
                }
                else
                {
                    if (distToShoulderX < 0.25)
                    {
                        if (nt15finished)
                        {
                            nt15finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt15.Open(new Uri(currDir + @"..\..\sounds\a57.wav"));
                                nt15.Play();
                                nt15.MediaEnded += delegate { nt15finished = true; };
                            });
                        }
                    }
                    else
                    {
                        if (nt13finished)
                        {
                            nt13finished = false;
                            this.Dispatcher.Invoke(() =>
                            {
                                nt13.MediaEnded += delegate { nt13finished = true; };
                                nt13.Play();
                                nt13.MediaEnded += delegate { nt13finished = true; };
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

            if (distToHipY < 0.5)
            {
                if (distToHipX < 0.18)
                {
                    if (nt12finished)
                    {
                        nt12finished = false;
                        this.Dispatcher.Invoke(() =>
                        {
                            nt12.Open(new Uri(currDir + @"..\..\sounds\a55.wav"));
                            nt12.Play();
                            nt12.MediaEnded += delegate { nt12finished = true; };
                        });
                    }
                }
                else if (distToHipX < 0.36)
                {
                    if (nt10finished)
                    {
                        nt10finished = false;
                        this.Dispatcher.Invoke(() =>
                        {
                            nt10.Open(new Uri(currDir + @"..\..\sounds\a54.wav"));
                            nt10.Play();
                            nt10.MediaEnded += delegate { nt10finished = true; };
                        });
                    }
                }
                else
                {
                    if (nt8finished)
                    {
                        nt8finished = false;
                        this.Dispatcher.Invoke(() =>
                        {
                            nt8.Open(new Uri(currDir + @"..\..\sounds\a53.wav"));
                            nt8.Play();
                            nt8.MediaEnded += delegate { nt8finished = true; };
                        });
                    }
                }
            }
            else if (distToHipY < 0.4)
            {
                if (distToHipX < 0.18)
                {
                    if (nt6finished)
                    {
                        nt6finished = false;
                        this.Dispatcher.Invoke(() =>
                        {
                            nt6.Open(new Uri(currDir + @"..\..\sounds\a52.wav"));
                            nt6.Play();
                            nt6.MediaEnded += delegate { nt6finished = true; };
                        });
                    }
                }
                else if (distToHipX < 0.36)
                {
                    if (nt4finished)
                    {
                        nt4finished = false;
                        this.Dispatcher.Invoke(() =>
                        {
                            nt4.Open(new Uri(currDir + @"..\..\sounds\b50.wav"));
                            nt4.Play();
                            nt4.MediaEnded += delegate { nt4finished = true; };
                        });
                    }
                }
                else
                {
                    if (nt2finished)
                    {
                        nt2finished = false;
                        this.Dispatcher.Invoke(() =>
                        {
                            nt2.Open(new Uri(currDir + @"..\..\sounds\b49.wav"));
                            nt2.Play();
                            nt2.MediaEnded += delegate { nt2finished = true; };
                        });
                    }
                }
            }
        }

        private void soundsRightLeg(float distToHipX, float distToHipY)
        {
            /*XValueRightAnkleToHip.Text = distToHipX.ToString(CultureInfo.InvariantCulture).Substring(0,5);
            YValueRightAnkleToHip.Text = distToHipY.ToString(CultureInfo.InvariantCulture).Substring(0,5);*/

            if (distToHipY < 0.5)
            {
                if (distToHipX < 0.18)
                {
                    if (nt11finished)
                    {
                        nt11finished = false;
                        this.Dispatcher.Invoke(() =>
                        {
                            nt11.Open(new Uri(currDir + @"..\..\sounds\b54.wav"));
                            nt11.Play();
                            nt11.MediaEnded += delegate { nt11finished = true; };
                        });
                    }
                }
                else if (distToHipX < 0.36)
                {
                    if (nt9finished)
                    {
                        nt9finished = false;
                        this.Dispatcher.Invoke(() =>
                        {
                            nt9.Open(new Uri(currDir + @"..\..\sounds\b53.wav"));
                            nt9.Play();
                            nt9.MediaEnded += delegate { nt9finished = true; };
                        });
                    }
                }
                else
                {
                    if (nt7finished)
                    {
                        nt7finished = false;
                        this.Dispatcher.Invoke(() =>
                        {
                            nt7.Open(new Uri(currDir + @"..\..\sounds\b52.wav"));
                            nt7.Play();
                            nt7.MediaEnded += delegate { nt7finished = true; };
                        });
                    }
                }
            }
            else if (distToHipY < 0.4)
            {
                if (distToHipX < 0.18)
                {
                    if (nt5finished)
                    {
                        nt5finished = false;
                        this.Dispatcher.Invoke(() =>
                        {
                            nt5.Open(new Uri(currDir + @"..\..\sounds\a51.wav"));
                            nt5.Play();
                            nt5.MediaEnded += delegate { nt5finished = true; };
                        });
                    }
                }
                else if (distToHipX < 0.36)
                {
                    if (nt3finished)
                    {
                        nt3finished = false;
                        this.Dispatcher.Invoke(() =>
                        {
                            nt3.Open(new Uri(currDir + @"..\..\sounds\a50.wav"));
                            nt3.Play();
                            nt3.MediaEnded += delegate { nt3finished = true; };
                        });
                    }
                }
                else
                {
                    if (nt1finished)
                    {
                        nt1finished = false;
                        this.Dispatcher.Invoke(() =>
                        {
                            nt1.Open(new Uri(currDir + @"..\..\sounds\a49.wav"));
                            nt1.Play();
                            nt1.MediaEnded += delegate { nt1finished = true; };
                        });
                    }
                }
            }
        }
    }
}
