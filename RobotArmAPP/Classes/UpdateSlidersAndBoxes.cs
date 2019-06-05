using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace RobotArmAPP.Classes
{
    class UpdateSlidersAndBoxes
    {
        Slider Eixo3Slider, Eixo2Slider, Eixo1Slider;
        TextBox Eixo3SliderBox, Eixo2SliderBox, Eixo1SliderBox;
        TextBox FrameSpeedBox, DelayBox, RepeatTimesBox;

        double axis3, axis2, axis1;
        int speed, delay, repeatTimes;

        public UpdateSlidersAndBoxes(Slider Eixo3Slider,
                                     Slider Eixo2Slider,
                                     Slider Eixo1Slider)
        {
            this.Eixo3Slider = Eixo3Slider;
            this.Eixo2Slider = Eixo2Slider;
            this.Eixo1Slider = Eixo1Slider;
        }

        public UpdateSlidersAndBoxes(TextBox Eixo3SliderBox,
                                     TextBox Eixo2SliderBox,
                                     TextBox Eixo1SliderBox,
                                     TextBox FrameSpeedBox,
                                     TextBox DelayBox,
                                     TextBox RepeatTimesBox)
        {
            this.Eixo3SliderBox = Eixo3SliderBox;
            this.Eixo2SliderBox = Eixo2SliderBox;
            this.Eixo1SliderBox = Eixo1SliderBox;
        }

        public UpdateSlidersAndBoxes(TextBox FrameSpeedBox, TextBox DelayBox, TextBox RepeatTimesBox)
        {
            this.FrameSpeedBox = FrameSpeedBox;
            this.DelayBox = DelayBox;
            this.RepeatTimesBox = RepeatTimesBox;
        }

        public void SendValuesToSliders()
        {
            Eixo3Slider.Value = axis3;
            Eixo2Slider.Value = axis2;
            Eixo1Slider.Value = axis1;
        }
        public void SendValuesToSlidersBoxes()
        {
            Eixo3SliderBox.Text = axis3.ToString();
            Eixo2SliderBox.Text = axis2.ToString();
            Eixo1SliderBox.Text = axis1.ToString();
        }
        public void SendValuesToControlsBoxes()
        {
            FrameSpeedBox.Text = speed.ToString();
            DelayBox.Text = delay.ToString();
            RepeatTimesBox.Text = repeatTimes.ToString();
        }
    }
}
