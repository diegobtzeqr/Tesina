using System;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Kinect;
using Microsoft.Kinect.Toolkit;

namespace Tesina
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private KinectSensor sensor;
		private readonly SoundPlayer nt1 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\a49.wav");
		private readonly SoundPlayer nt2 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\b49.wav");
		private readonly SoundPlayer nt3 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\a50.wav");
		private readonly SoundPlayer nt4 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\b50.wav");
		private readonly SoundPlayer nt5 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\a51.wav");
		private readonly SoundPlayer nt6 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\a52.wav");
		private readonly SoundPlayer nt7 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\b52.wav");
		private readonly SoundPlayer nt8 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\a53.wav");
		private readonly SoundPlayer nt9 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\b53.wav");
		private readonly SoundPlayer nt10 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\a54.wav");
		private readonly SoundPlayer nt11 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\b54.wav");
		private readonly SoundPlayer nt12 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\a55.wav");
		private readonly SoundPlayer nt13 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\a56.wav");
		private readonly SoundPlayer nt14 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\b56.wav");
		private readonly SoundPlayer nt15 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\a57.wav");
		private readonly SoundPlayer nt16 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\a48.wav");
		private readonly SoundPlayer nt17 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\a81.wav");
		private readonly SoundPlayer nt18 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\b81.wav");
		private readonly SoundPlayer nt19 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\a87.wav");
		private readonly SoundPlayer nt20 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\b87.wav");
		private readonly SoundPlayer nt21 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\a69.wav");
		private readonly SoundPlayer nt22 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\b69.wav");
		private readonly SoundPlayer nt23 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\a82.wav");
		private readonly SoundPlayer nt24 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\a84.wav");
		private readonly SoundPlayer nt25 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\b84.wav");
		private readonly SoundPlayer nt26 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\a89.wav");
		private readonly SoundPlayer nt27 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\b89.wav");
		private readonly SoundPlayer nt28 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\a85.wav");
		private readonly SoundPlayer nt29 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\a73.wav");
		private readonly SoundPlayer nt30 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\b73.wav");
		private readonly SoundPlayer nt31 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\a79.wav");
		private readonly SoundPlayer nt32 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\b79.wav");
		private readonly SoundPlayer nt33 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\a80.wav");
		private readonly SoundPlayer nt34 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\b80.wav");
		private readonly SoundPlayer nt35 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\a65.wav");
		private readonly SoundPlayer nt36 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\a83.wav");
		private readonly SoundPlayer nt37 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\b83.wav");
		private readonly SoundPlayer nt38 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\a68.wav");
		private readonly SoundPlayer nt39 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\b68.wav");
		private readonly SoundPlayer nt40 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\a70.wav");
		private readonly SoundPlayer nt41 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\a71.wav");
		private readonly SoundPlayer nt42 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\b71.wav");
		private readonly SoundPlayer nt43 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\a72.wav");
		private readonly SoundPlayer nt44 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\b72.wav");
		private readonly SoundPlayer nt45 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\a74.wav");
		private readonly SoundPlayer nt46 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\b74.wav");
		private readonly SoundPlayer nt47 = new SoundPlayer(@"C:\Users\Diego Be\source\repos\Tesina\Tesina\sounds\a75.wav");
		private bool nt1Finished = true;
		private bool nt2Finished = true;
		private bool nt3Finished = true;
		private bool nt4Finished = true;
		private bool nt5Finished = true;
		private bool nt6Finished = true;
		private bool nt7Finished = true;
		private bool nt8Finished = true;
		private bool nt9Finished = true;
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

		public MainWindow()
		{
			InitializeComponent();
			Loaded += MainWindowLoaded;
		}

		private void MainWindowLoaded(object sender, RoutedEventArgs e)
		{
			nt1.Load();
			nt2.Load();
			nt3.Load();
			nt4.Load();
			nt5.Load();
			nt6.Load();
			nt7.Load();
			nt8.Load();
			nt9.Load();
			nt10.Load();
			nt11.Load();
			nt12.Load();
			nt13.Load();
			nt14.Load();
			nt15.Load();
			nt16.Load();
			nt17.Load();
			nt18.Load();
			nt19.Load();
			nt20.Load();
			nt21.Load();
			nt22.Load();
			nt23.Load();
			nt24.Load();
			nt25.Load();
			nt26.Load();
			nt27.Load();
			nt28.Load();
			nt29.Load();
			nt30.Load();
			nt31.Load();
			nt32.Load();
			nt33.Load();
			nt34.Load();
			nt35.Load();
			nt36.Load();
			nt37.Load();
			nt38.Load();
			nt39.Load();
			nt40.Load();
			nt41.Load();
			nt42.Load();
			nt43.Load();
			nt44.Load();
			nt45.Load();
			nt46.Load();
			nt47.Load();
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

			soundsLeftArm(Math.Abs(leftHand.Position.X - leftShoulder.Position.X), Math.Abs(leftHand.Position.Y - leftShoulder.Position.Y), Math.Abs(leftHand.Position.Z - leftShoulder.Position.Z),
						  Math.Abs(leftHand.Position.X - leftHip.Position.X), Math.Abs(leftHand.Position.Y - leftHip.Position.Y), Math.Abs(leftHand.Position.Z - leftHip.Position.Z));
			soundsRightArm(Math.Abs(rightHand.Position.X - rightShoulder.Position.X), Math.Abs(rightHand.Position.Y - rightShoulder.Position.Y), Math.Abs(rightHand.Position.Z - rightShoulder.Position.Z),
						   Math.Abs(rightHand.Position.X - rightHip.Position.X), Math.Abs(rightHand.Position.Y - rightHip.Position.Y), Math.Abs(rightHand.Position.Z - rightHip.Position.Z));
			soundsLeftLeg(Math.Abs(leftAnkle.Position.X - leftHip.Position.X), Math.Abs(leftAnkle.Position.Y - leftHip.Position.Y), Math.Abs(leftAnkle.Position.Z - leftHip.Position.Z));
			soundsRightLeg(Math.Abs(rightAnkle.Position.X - rightHip.Position.X), Math.Abs(rightAnkle.Position.Y - rightHip.Position.Y), Math.Abs(rightAnkle.Position.Z - rightHip.Position.Z));
		}


		private void soundsLeftArm(float distToShoulderX, float distToShoulderY, float distToShoulderZ, float distToHipX, float distToHipY, float distToHipZ)
		{
			XValueLeftWristToShoulder.Text = distToShoulderX.ToString(CultureInfo.InvariantCulture).Substring(0,5);
			YValueLeftWristToShoulder.Text = distToShoulderY.ToString(CultureInfo.InvariantCulture).Substring(0, 5);
			ZValueLeftWristToShoulder.Text = distToShoulderZ.ToString(CultureInfo.InvariantCulture).Substring(0, 5);

			XValueLeftWristToHip.Text = distToHipX.ToString(CultureInfo.InvariantCulture).Substring(0, 5);
			YValueLeftWristToHip.Text = distToHipY.ToString(CultureInfo.InvariantCulture).Substring(0, 5);
			ZValueLeftWristToHip.Text = distToHipZ.ToString(CultureInfo.InvariantCulture).Substring(0, 5);

			if (distToShoulderY > 0.36 && distToHipY > 0.8 && distToShoulderX < 0.2 && distToHipX < 0.2 && distToShoulderZ < 0.2 && distToHipZ < 0.2) 
			{
				if (nt47Finished)
				{
					nt47Finished = false;
					Task.Factory.StartNew(() => {
						nt47.PlaySync();
						nt47Finished = true;
					});
				}
			}
			else if (distToShoulderY > 0.2 && distToHipY > 0.64 && distToShoulderX < 0.35 && distToHipX < 0.35 && distToShoulderZ < 0.2 && distToHipZ < 0.2)
			{
				if (nt46Finished)
				{
					nt46Finished = false;
					Task.Factory.StartNew(() => {
						nt46.PlaySync();
						nt46Finished = true;
					});
				}
			}
		}

		private void soundsRightArm(float distToShoulderX, float distToShoulderY, float distToShoulderZ, float distToHipX, float distToHipY, float distToHipZ)
		{
			XValueRightWristToShoulder.Text = distToShoulderX.ToString(CultureInfo.InvariantCulture).Substring(0, 5);
			YValueRightWristToShoulder.Text = distToShoulderY.ToString(CultureInfo.InvariantCulture).Substring(0, 5);
			ZValueRightWristToShoulder.Text = distToShoulderZ.ToString(CultureInfo.InvariantCulture).Substring(0, 5);

			XValueRightWristToHip.Text = distToHipX.ToString(CultureInfo.InvariantCulture).Substring(0, 5);
			YValueRightWristToHip.Text = distToHipY.ToString(CultureInfo.InvariantCulture).Substring(0, 5);
			ZValueRightWristToHip.Text = distToHipZ.ToString(CultureInfo.InvariantCulture).Substring(0, 5);
		}

		private void soundsLeftLeg(float distToHipX, float distToHipY, float distToHipZ)
		{
			XValueLeftAnkleToHip.Text = distToHipX.ToString(CultureInfo.InvariantCulture).Substring(0, 5);
			YValueLeftAnkleToHip.Text = distToHipY.ToString(CultureInfo.InvariantCulture).Substring(0, 5);
			ZValueLeftAnkleToHip.Text = distToHipZ.ToString(CultureInfo.InvariantCulture).Substring(0, 5);
		}

		private void soundsRightLeg(float distToHipX, float distToHipY, float distToHipZ)
		{
			XValueRightAnkleToHip.Text = distToHipX.ToString(CultureInfo.InvariantCulture).Substring(0, 5);
			YValueRightAnkleToHip.Text = distToHipY.ToString(CultureInfo.InvariantCulture).Substring(0, 5);
			ZValueRightAnkleToHip.Text = distToHipZ.ToString(CultureInfo.InvariantCulture).Substring(0, 5);
		}
	}
}
