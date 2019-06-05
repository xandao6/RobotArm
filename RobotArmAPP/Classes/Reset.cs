using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace RobotArmAPP.Classes
{
    class Reset
    {
        public void ResetControls(Slider Eixo1Slider,
                                  Slider Eixo2Slider,
                                  Slider Eixo3Slider,
                                  TextBox RepeatTimesBox,
                                  TextBox FrameSpeedBox,
                                  TextBox DelayBox,
                                  ListView FramesListView,
                                  List<int[]> framesList,
                                  Movement defaultMovement)
        {
            Eixo1Slider.Value = defaultMovement.Axis1;
            Eixo2Slider.Value = defaultMovement.Axis2;
            Eixo3Slider.Value = defaultMovement.Axis3;
            FrameSpeedBox.Text = Convert.ToString(defaultMovement.Speed);
            DelayBox.Text = Convert.ToString(defaultMovement.Delay);
            RepeatTimesBox.Text = Convert.ToString(defaultMovement.RepeatTimes);
            FramesListView.Items.Clear();
            framesList.Clear();
        }
    }
}
