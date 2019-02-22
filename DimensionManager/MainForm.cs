using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Numerics;
using DimensionManager.SerializableObjects;

namespace DimensionManager
{
    public partial class MainForm : Form
    {
        private const string SavedNotificationText = "Успешно сохранено";
        private const int SavedNotificationDuration = 2000;

        public MainForm()
        {
            InitializeComponent();
            axisSelectCombo.SelectedIndex = 0;

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = "XML File | *.xml";
                if (DialogResult.OK != dialog.ShowDialog(this))
                {
                    return;
                }
                Save(dialog.FileName);
            }
        }

        private void Save(string fileName)
        {
            if(string.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentException($"Blank or null '{nameof(fileName)}' param provided");
            }

            CalibrationInfo calibrationInfo = CreateCalibrationInfo();
            var serializer = new XmlSerializer(calibrationInfo.GetType());
            try
            {
                using (var writer = new StreamWriter(fileName, false, Encoding.UTF8))
                {
                    serializer.Serialize(writer, calibrationInfo);
                }
                ShowSavedNotification();
            }
            catch (Exception e)
            {
                MessageBox.Show("Не удалось сохранить файл.\n" + e.Message, "Ошибка при сохранении",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ShowSavedNotification()
        {
            savedNotificationLabel.Text = SavedNotificationText;
            await Task.Delay(SavedNotificationDuration);
            savedNotificationLabel.Text = "";
        }

        private CalibrationInfo CreateCalibrationInfo()
        {
            CoordianteSystem cs = CalcCoordinateSystem();

            Vector3 masterAnt           = cs.GetLocalPoint(masterAntBox.Vector);
            Vector3 azimuthAnt          = cs.GetLocalPoint(azimuthAntBox.Vector);
            Vector3 bitOffset           = cs.GetLocalPoint(bitOffsetBox.Vector);
            Vector3 mastRotateOffset    = cs.GetLocalPoint(mastRotateOffsetBox.Vector);
            Vector3 frontLeftJack       = cs.GetLocalPoint(frontLeftJackBox.Vector);
            Vector3 frontRightJack      = cs.GetLocalPoint(frontRightJackBox.Vector);
            Vector3 backJack            = cs.GetLocalPoint(backJackBox.Vector);

            float platformOffsetZ       = platformOffsetZBox.Value;

            var calibrationInfo = new CalibrationInfo
            {
                CriticalAngle = 0,

                AzimuthAntennaOffsetX = azimuthAnt.X,
                AzimuthAntennaOffsetY = azimuthAnt.Y,

                MastRotateOffsetX = mastRotateOffset.X,
                MastRotateOffsetY = mastRotateOffset.Y,
                MastRotateOffsetZ = mastRotateOffset.Z,

                BitOffsetX = bitOffset.X,
                BitOffsetY = bitOffset.Y,
                BitOffsetZ = bitOffset.Z,

                MastAngleOffset = 0,
                DrillRollOffset = 0,
                DrillPitchOffset = 0,

                PlatformOffsetZ = platformOffsetZ,

                SourceMastRotateOffsetX = mastRotateOffset.X,
                SourceMastRotateOffsetY = mastRotateOffset.Y,

                SourceBitOffsetX = bitOffset.X,
                SourceBitOffsetY = bitOffset.Y,
                SourceBitOffsetZ = bitOffset.Z,

                SourceFrontRightJack = new SourceFrontRightJack
                {
                    OffsetX = frontRightJack.X,
                    OffsetY = frontRightJack.Y
                },
                SourceFrontLeftJack = new SourceFrontLeftJack
                {
                    OffsetX = frontLeftJack.X,
                    OffsetY = frontLeftJack.Y
                },
                SourceBackJack = new SourceBackJack
                {
                    OffsetX = backJack.X,
                    OffsetY = backJack.Y
                },

                FrontRightJack = new FrontRightJack
                {
                    OffsetX = frontRightJack.X,
                    OffsetY = frontRightJack.Y
                },
                FrontLeftJack = new FrontLeftJack
                {
                    OffsetX = frontLeftJack.X,
                    OffsetY = frontLeftJack.Y
                },
                BackJack = new BackJack
                {
                    OffsetX = backJack.X,
                    OffsetY = backJack.Y
                }
            };
            return calibrationInfo;
        }

        private CoordianteSystem CalcCoordinateSystem()
        {
            Vector3 axisX, axisY;
            var specifiedAxis = Vector3.Normalize(axisBBox.Vector - axisABox.Vector);
            if (axisSelectCombo.SelectedIndex == 0)
            {
                axisX = specifiedAxis;
                axisY = Vector3.Normalize(new Vector3(-axisX.Y, axisX.X, 0));
            }
            else
            {
                axisY = specifiedAxis;
                axisX = Vector3.Normalize(new Vector3(axisY.Y, -axisY.X, 0));
            }
            var axisZ = Vector3.Cross(axisX, axisY);
            return new CoordianteSystem(masterAntBox.Vector, axisX, axisY, axisZ);
        }
    }
}
