using RobotArmAPP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace RobotArmAPP.Classes
{
    class SpeedControl
    {
        DelayControl delayControl = new DelayControl();
        /*public async Task<int> GarraSpeedControl()
        {

            return 0;
        }

        public async Task<int> Axis4SpeedControl()
        {

            return 0;
        }

        public async Task<int> Axis3SpeedControl()
        {

            return 0;
        }

        public async Task<int> Axis2SpeedControl()
        {

            return 0;
        }*/

        public async Task<int> Axis1SpeedControl(Slider Eixo1Slider, ListView FramesListView)
        {
            FramesListView.SelectedIndex = Controller.currentFramePosition;
            int selectedFrameAxis1 = Controller.framesList[Controller.currentFramePosition][4];
            int delayMinimumAxis1 = DelayControl.axisDelayList[Controller.currentFramePosition][4];

            if (Controller.currentFramePosition == 0)
            {
                int lastFrameAxis1 = Controller.framesList[FramesListView.Items.Count - 1][4];
                if (selectedFrameAxis1 > lastFrameAxis1)
                {
                    for (int x = lastFrameAxis1; x < selectedFrameAxis1; x++)
                    {
                        Eixo1Slider.Value += 1;
                        await Task.Delay(delayMinimumAxis1 / 10);
                    }
                }
                else if (selectedFrameAxis1 < lastFrameAxis1)
                {
                    for (int x = lastFrameAxis1; x > selectedFrameAxis1; x--)
                    {
                        Eixo1Slider.Value--;
                        await Task.Delay(delayMinimumAxis1 / 10);
                    }
                }
            }
            else
            {
                int previousFrameAxis1 = Controller.framesList[Controller.currentFramePosition - 1][4];
                if (selectedFrameAxis1 > previousFrameAxis1)
                {
                    for (int x = previousFrameAxis1; x < selectedFrameAxis1; x++)
                    {
                        Eixo1Slider.Value += 1;
                        await Task.Delay(delayMinimumAxis1 / 10);
                    }
                }
                else if (selectedFrameAxis1 < previousFrameAxis1)
                {
                    for (int x = previousFrameAxis1; x > selectedFrameAxis1; x--)
                    {
                        Eixo1Slider.Value--;
                        await Task.Delay(delayMinimumAxis1 / 10);
                    }
                }
            }
            return 1;
        }
    }
}
