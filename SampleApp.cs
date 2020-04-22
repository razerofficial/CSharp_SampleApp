using ChromaSDK;
using System;

namespace CSharp_SampleApp
{
    public class SampleApp
    {
        private int _mResult = 0;

        public int GetInitResult()
        {
            return _mResult;
        }

        public void Start()
        {
            _mResult = ChromaAnimationAPI.Init();
            switch (_mResult)
            {
                case RazerErrors.RZRESULT_DLL_NOT_FOUND:
                    Console.Error.WriteLine("Chroma DLL is not found! {0}", RazerErrors.GetResultString(_mResult));
                    break;
                case RazerErrors.RZRESULT_DLL_INVALID_SIGNATURE:
                    Console.Error.WriteLine("Chroma DLL has an invalid signature! {0}", RazerErrors.GetResultString(_mResult));
                    break;
                case RazerErrors.RZRESULT_SUCCESS:
                    break;
                default:
                    Console.Error.WriteLine("Failed to initialize Chroma! {0}", RazerErrors.GetResultString(_mResult));
                    break;
            }
        }
        public void OnApplicationQuit()
        {
            ChromaAnimationAPI.Uninit();
        }

        public string GetEffectName(int index)
        {
            string result = string.Format("Effect{0}", index);
            return result;
        }

        public void ExecuteItem(int index)
        {
            switch (index)
            {
                case 1:
                    ShowEffect1();
                    break;
                case 2:
                    ShowEffect2();
                    break;
                case 3:
                    ShowEffect3();
                    break;
                case 4:
                    ShowEffect4();
                    break;
                case 5:
                    ShowEffect5();
                    break;
                case 6:
                    ShowEffect6();
                    break;
                case 7:
                    ShowEffect7();
                    break;
                case 8:
                    ShowEffect8();
                    break;
                case 9:
                    ShowEffect9();
                    break;
                case 10:
                    ShowEffect10();
                    break;
                case 11:
                    ShowEffect11();
                    break;
                case 12:
                    ShowEffect12();
                    break;
                case 13:
                    ShowEffect13();
                    break;
                case 14:
                    ShowEffect14();
                    break;
                case 15:
                    ShowEffect15();
                    break;
                case 16:
                    ShowEffect16();
                    break;
                case 17:
                    ShowEffect17();
                    break;
                case 18:
                    ShowEffect18();
                    break;
                case 19:
                    ShowEffect19();
                    break;
                case 20:
                    ShowEffect20();
                    break;
                case 21:
                    ShowEffect21();
                    break;
                case 22:
                    ShowEffect22();
                    break;
                case 23:
                    ShowEffect23();
                    break;
                case 24:
                    ShowEffect24();
                    break;
                case 25:
                    ShowEffect25();
                    break;
                case 26:
                    ShowEffect26();
                    break;
                case 27:
                    ShowEffect27();
                    break;
                case 28:
                    ShowEffect28();
                    break;
                case 29:
                    ShowEffect29();
                    break;
                case 30:
                    ShowEffect30();
                    break;
                case 31:
                    ShowEffect31();
                    break;
                case 32:
                    ShowEffect32();
                    break;
                case 33:
                    ShowEffect33();
                    break;
                case 34:
                    ShowEffect34();
                    break;
                case 35:
                    ShowEffect35();
                    break;
                case 36:
                    ShowEffect36();
                    break;
                case 37:
                    ShowEffect37();
                    break;
                case 38:
                    ShowEffect38();
                    break;
                case 39:
                    ShowEffect39();
                    break;
                case 40:
                    ShowEffect40();
                    break;
            }
        }

        #region Autogenerated
        void ShowEffect1()
        {
            // start with a blank animation
            string baseLayer = "animations/Sprite1_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect1ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "animations/Sprite1_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect1Headset()
        {
            // start with a blank animation
            string baseLayer = "animations/Sprite1_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect1Mousepad()
        {
            // start with a blank animation
            string baseLayer = "animations/Sprite1_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect1Mouse()
        {
            // start with a blank animation
            string baseLayer = "animations/Sprite1_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect2()
        {
            // start with a blank animation
            string baseLayer = "Animations/Tongue1_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect2ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/Tongue1_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect2Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/Tongue1_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect2Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/Tongue1_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect2Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/Tongue1_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect3()
        {
            // start with a blank animation
            string baseLayer = "Animations/Tongue1_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // set middle color green
            ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 255, 0);
            int minThreshold = 50; //set outer color to red
            int maxThreshold = 150; //set main color to blue
            ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 255, 0, 0, maxThreshold, 0, 0, 255);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect3ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/Tongue1_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // set middle color green
            ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 255, 0);
            int minThreshold = 50; //set outer color to red
            int maxThreshold = 150; //set main color to blue
            ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 255, 0, 0, maxThreshold, 0, 0, 255);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect3Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/Tongue1_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // set middle color green
            ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 255, 0);
            int minThreshold = 50; //set outer color to red
            int maxThreshold = 150; //set main color to blue
            ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 255, 0, 0, maxThreshold, 0, 0, 255);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect3Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/Tongue1_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // set middle color green
            ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 255, 0);
            int minThreshold = 50; //set outer color to red
            int maxThreshold = 150; //set main color to blue
            ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 255, 0, 0, maxThreshold, 0, 0, 255);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect3Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/Tongue1_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // set middle color green
            ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 255, 0);
            int minThreshold = 50; //set outer color to red
            int maxThreshold = 150; //set main color to blue
            ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 255, 0, 0, maxThreshold, 0, 0, 255);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect4()
        {
            // start with a blank animation
            string baseLayer = "Animations/OutParticle1_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect4ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/OutParticle1_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect4Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/OutParticle1_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect4Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/OutParticle1_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect4Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/OutParticle1_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect5()
        {
            // start with a blank animation
            string baseLayer = "Animations/OutParticle1_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // turn grayscale particles to blue water
            ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 127, 255);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect5ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/OutParticle1_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // turn grayscale particles to blue water
            ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 127, 255);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect5Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/OutParticle1_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // turn grayscale particles to blue water
            ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 127, 255);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect5Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/OutParticle1_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // turn grayscale particles to blue water
            ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 127, 255);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect5Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/OutParticle1_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // turn grayscale particles to blue water
            ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 127, 255);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect6()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // the length of the animation
            int frameCount = 50;
            // set all frames to white, with all frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
            // fade the start of the animation starting at frame zero to 40
            ChromaAnimationAPI.FadeStartFramesName(baseLayer, 40);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect6ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // the length of the animation
            int frameCount = 50;
            // set all frames to white, with all frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
            // fade the start of the animation starting at frame zero to 40
            ChromaAnimationAPI.FadeStartFramesName(baseLayer, 40);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect6Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // the length of the animation
            int frameCount = 50;
            // set all frames to white, with all frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
            // fade the start of the animation starting at frame zero to 40
            ChromaAnimationAPI.FadeStartFramesName(baseLayer, 40);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect6Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // the length of the animation
            int frameCount = 50;
            // set all frames to white, with all frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
            // fade the start of the animation starting at frame zero to 40
            ChromaAnimationAPI.FadeStartFramesName(baseLayer, 40);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect6Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // the length of the animation
            int frameCount = 50;
            // set all frames to white, with all frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
            // fade the start of the animation starting at frame zero to 40
            ChromaAnimationAPI.FadeStartFramesName(baseLayer, 40);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect7()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // the length of the animation
            int frameCount = 50;
            // set all frames to white, with all frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
            // fade the end of the animation starting at frame length - 40 (60)
            ChromaAnimationAPI.FadeEndFramesName(baseLayer, 40);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect7ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // the length of the animation
            int frameCount = 50;
            // set all frames to white, with all frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
            // fade the end of the animation starting at frame length - 40 (60)
            ChromaAnimationAPI.FadeEndFramesName(baseLayer, 40);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect7Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // the length of the animation
            int frameCount = 50;
            // set all frames to white, with all frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
            // fade the end of the animation starting at frame length - 40 (60)
            ChromaAnimationAPI.FadeEndFramesName(baseLayer, 40);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect7Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // the length of the animation
            int frameCount = 50;
            // set all frames to white, with all frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
            // fade the end of the animation starting at frame length - 40 (60)
            ChromaAnimationAPI.FadeEndFramesName(baseLayer, 40);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect7Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // the length of the animation
            int frameCount = 50;
            // set all frames to white, with all frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
            // fade the end of the animation starting at frame length - 40 (60)
            ChromaAnimationAPI.FadeEndFramesName(baseLayer, 40);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect8()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // the length of the animation
            int frameCount = 50;
            // set all frames to white, with all frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
            // fade the start of the animation starting at frame zero to 40
            ChromaAnimationAPI.FadeStartFramesName(baseLayer, 40);
            // fade the end of the animation starting at frame length - 40 (60)
            ChromaAnimationAPI.FadeEndFramesName(baseLayer, 40);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect8ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // the length of the animation
            int frameCount = 50;
            // set all frames to white, with all frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
            // fade the start of the animation starting at frame zero to 40
            ChromaAnimationAPI.FadeStartFramesName(baseLayer, 40);
            // fade the end of the animation starting at frame length - 40 (60)
            ChromaAnimationAPI.FadeEndFramesName(baseLayer, 40);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect8Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // the length of the animation
            int frameCount = 50;
            // set all frames to white, with all frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
            // fade the start of the animation starting at frame zero to 40
            ChromaAnimationAPI.FadeStartFramesName(baseLayer, 40);
            // fade the end of the animation starting at frame length - 40 (60)
            ChromaAnimationAPI.FadeEndFramesName(baseLayer, 40);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect8Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // the length of the animation
            int frameCount = 50;
            // set all frames to white, with all frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
            // fade the start of the animation starting at frame zero to 40
            ChromaAnimationAPI.FadeStartFramesName(baseLayer, 40);
            // fade the end of the animation starting at frame length - 40 (60)
            ChromaAnimationAPI.FadeEndFramesName(baseLayer, 40);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect8Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // the length of the animation
            int frameCount = 50;
            // set all frames to white, with all frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
            // fade the start of the animation starting at frame zero to 40
            ChromaAnimationAPI.FadeStartFramesName(baseLayer, 40);
            // fade the end of the animation starting at frame length - 40 (60)
            ChromaAnimationAPI.FadeEndFramesName(baseLayer, 40);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect9()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // the length of the animation
            int frameCount = 50;
            // set all frames to white, with all frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
            //integer number of times to blink during animation
            int speed = 2;
            // loop over all frames in the layer
            for (int frameId = 0; frameId < frameCount; ++frameId)
            {
                //Math.cos gives a smooth 1 to 0 to 1 curve, subtracting from one inverts the curve
                float t = 1 - (float)Math.Cos(speed * Math.PI * (frameId + 1) / (float)frameCount);
                // multiply the frame by the 't' intensity
                ChromaAnimationAPI.MultiplyIntensityName(baseLayer, frameId, t);
            }
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect9ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // the length of the animation
            int frameCount = 50;
            // set all frames to white, with all frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
            //integer number of times to blink during animation
            int speed = 2;
            // loop over all frames in the layer
            for (int frameId = 0; frameId < frameCount; ++frameId)
            {
                //Math.cos gives a smooth 1 to 0 to 1 curve, subtracting from one inverts the curve
                float t = 1 - (float)Math.Cos(speed * Math.PI * (frameId + 1) / (float)frameCount);
                // multiply the frame by the 't' intensity
                ChromaAnimationAPI.MultiplyIntensityName(baseLayer, frameId, t);
            }
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect9Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // the length of the animation
            int frameCount = 50;
            // set all frames to white, with all frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
            //integer number of times to blink during animation
            int speed = 2;
            // loop over all frames in the layer
            for (int frameId = 0; frameId < frameCount; ++frameId)
            {
                //Math.cos gives a smooth 1 to 0 to 1 curve, subtracting from one inverts the curve
                float t = 1 - (float)Math.Cos(speed * Math.PI * (frameId + 1) / (float)frameCount);
                // multiply the frame by the 't' intensity
                ChromaAnimationAPI.MultiplyIntensityName(baseLayer, frameId, t);
            }
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect9Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // the length of the animation
            int frameCount = 50;
            // set all frames to white, with all frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
            //integer number of times to blink during animation
            int speed = 2;
            // loop over all frames in the layer
            for (int frameId = 0; frameId < frameCount; ++frameId)
            {
                //Math.cos gives a smooth 1 to 0 to 1 curve, subtracting from one inverts the curve
                float t = 1 - (float)Math.Cos(speed * Math.PI * (frameId + 1) / (float)frameCount);
                // multiply the frame by the 't' intensity
                ChromaAnimationAPI.MultiplyIntensityName(baseLayer, frameId, t);
            }
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect9Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // the length of the animation
            int frameCount = 50;
            // set all frames to white, with all frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.033f, 255, 255, 255);
            //integer number of times to blink during animation
            int speed = 2;
            // loop over all frames in the layer
            for (int frameId = 0; frameId < frameCount; ++frameId)
            {
                //Math.cos gives a smooth 1 to 0 to 1 curve, subtracting from one inverts the curve
                float t = 1 - (float)Math.Cos(speed * Math.PI * (frameId + 1) / (float)frameCount);
                // multiply the frame by the 't' intensity
                ChromaAnimationAPI.MultiplyIntensityName(baseLayer, frameId, t);
            }
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect10()
        {
            // start with a blank animation
            string baseLayer = "Animations/Clouds1_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect10ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/Clouds1_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect10Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/Clouds1_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect10Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/Clouds1_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect10Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/Clouds1_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect11()
        {
            // start with a blank animation
            string baseLayer = "Animations/Clouds1_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // reduce the intensity of the layer
            ChromaAnimationAPI.MultiplyIntensityAllFramesName(baseLayer, 0.25f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect11ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/Clouds1_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // reduce the intensity of the layer
            ChromaAnimationAPI.MultiplyIntensityAllFramesName(baseLayer, 0.25f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect11Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/Clouds1_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // reduce the intensity of the layer
            ChromaAnimationAPI.MultiplyIntensityAllFramesName(baseLayer, 0.25f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect11Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/Clouds1_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // reduce the intensity of the layer
            ChromaAnimationAPI.MultiplyIntensityAllFramesName(baseLayer, 0.25f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect11Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/Clouds1_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // reduce the intensity of the layer
            ChromaAnimationAPI.MultiplyIntensityAllFramesName(baseLayer, 0.25f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect12()
        {
            // start with a blank animation
            string baseLayer = "Animations/BlackAndWhiteRainbow_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect12ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/BlackAndWhiteRainbow_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect12Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/BlackAndWhiteRainbow_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect12Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/BlackAndWhiteRainbow_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect12Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/BlackAndWhiteRainbow_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect13()
        {
            // start with a blank animation
            string baseLayer = "Animations/BlackAndWhiteRainbow_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
            // loop over all frames in the layer
            for (int frameId = 0; frameId < frameCount; ++frameId)
            {
                // give color to the layer
                ChromaAnimationAPI.MultiplyIntensityRGBName(baseLayer, frameId, 255, 255, 0); //yellow
            }
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect13ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/BlackAndWhiteRainbow_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
            // loop over all frames in the layer
            for (int frameId = 0; frameId < frameCount; ++frameId)
            {
                // give color to the layer
                ChromaAnimationAPI.MultiplyIntensityRGBName(baseLayer, frameId, 255, 255, 0); //yellow
            }
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect13Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/BlackAndWhiteRainbow_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
            // loop over all frames in the layer
            for (int frameId = 0; frameId < frameCount; ++frameId)
            {
                // give color to the layer
                ChromaAnimationAPI.MultiplyIntensityRGBName(baseLayer, frameId, 255, 255, 0); //yellow
            }
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect13Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/BlackAndWhiteRainbow_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
            // loop over all frames in the layer
            for (int frameId = 0; frameId < frameCount; ++frameId)
            {
                // give color to the layer
                ChromaAnimationAPI.MultiplyIntensityRGBName(baseLayer, frameId, 255, 255, 0); //yellow
            }
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect13Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/BlackAndWhiteRainbow_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
            // loop over all frames in the layer
            for (int frameId = 0; frameId < frameCount; ++frameId)
            {
                // give color to the layer
                ChromaAnimationAPI.MultiplyIntensityRGBName(baseLayer, frameId, 255, 255, 0); //yellow
            }
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect14()
        {
            // start with a blank animation
            string baseLayer = "Animations/BlackAndWhiteRainbow_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 255, 255); //cyan
                                                                                          // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect14ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/BlackAndWhiteRainbow_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 255, 255); //cyan
                                                                                          // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect14Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/BlackAndWhiteRainbow_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 255, 255); //cyan
                                                                                          // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect14Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/BlackAndWhiteRainbow_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 255, 255); //cyan
                                                                                          // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect14Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/BlackAndWhiteRainbow_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            ChromaAnimationAPI.MultiplyIntensityAllFramesRGBName(baseLayer, 0, 255, 255); //cyan
                                                                                          // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect15()
        {
            // start with a blank animation
            string baseLayer = "Animations/BlackAndWhiteRainbow_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
            int color1 = ChromaAnimationAPI.GetRGB(255, 0, 0); //red
            int color2 = ChromaAnimationAPI.GetRGB(0, 255, 0); //green
                                                               //integer number of times to transition during animation
            int speed = 2;
            // loop over all frames in the layer
            for (int frameId = 0; frameId < frameCount; ++frameId)
            {
                //Math.cos gives a smooth 1 to 0 to 1 curve
                float t = (float)Math.Cos(speed * Math.PI * (frameId + 1) / (float)frameCount);
                // use t to transition from color 1 to color 2
                int color = ChromaAnimationAPI.LerpColor(color1, color2, t);
                // give color to the layer
                ChromaAnimationAPI.MultiplyIntensityColorName(baseLayer, frameId, color);
            }
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect15ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/BlackAndWhiteRainbow_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
            int color1 = ChromaAnimationAPI.GetRGB(255, 0, 0); //red
            int color2 = ChromaAnimationAPI.GetRGB(0, 255, 0); //green
                                                               //integer number of times to transition during animation
            int speed = 2;
            // loop over all frames in the layer
            for (int frameId = 0; frameId < frameCount; ++frameId)
            {
                //Math.cos gives a smooth 1 to 0 to 1 curve
                float t = (float)Math.Cos(speed * Math.PI * (frameId + 1) / (float)frameCount);
                // use t to transition from color 1 to color 2
                int color = ChromaAnimationAPI.LerpColor(color1, color2, t);
                // give color to the layer
                ChromaAnimationAPI.MultiplyIntensityColorName(baseLayer, frameId, color);
            }
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect15Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/BlackAndWhiteRainbow_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
            int color1 = ChromaAnimationAPI.GetRGB(255, 0, 0); //red
            int color2 = ChromaAnimationAPI.GetRGB(0, 255, 0); //green
                                                               //integer number of times to transition during animation
            int speed = 2;
            // loop over all frames in the layer
            for (int frameId = 0; frameId < frameCount; ++frameId)
            {
                //Math.cos gives a smooth 1 to 0 to 1 curve
                float t = (float)Math.Cos(speed * Math.PI * (frameId + 1) / (float)frameCount);
                // use t to transition from color 1 to color 2
                int color = ChromaAnimationAPI.LerpColor(color1, color2, t);
                // give color to the layer
                ChromaAnimationAPI.MultiplyIntensityColorName(baseLayer, frameId, color);
            }
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect15Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/BlackAndWhiteRainbow_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
            int color1 = ChromaAnimationAPI.GetRGB(255, 0, 0); //red
            int color2 = ChromaAnimationAPI.GetRGB(0, 255, 0); //green
                                                               //integer number of times to transition during animation
            int speed = 2;
            // loop over all frames in the layer
            for (int frameId = 0; frameId < frameCount; ++frameId)
            {
                //Math.cos gives a smooth 1 to 0 to 1 curve
                float t = (float)Math.Cos(speed * Math.PI * (frameId + 1) / (float)frameCount);
                // use t to transition from color 1 to color 2
                int color = ChromaAnimationAPI.LerpColor(color1, color2, t);
                // give color to the layer
                ChromaAnimationAPI.MultiplyIntensityColorName(baseLayer, frameId, color);
            }
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect15Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/BlackAndWhiteRainbow_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
            int color1 = ChromaAnimationAPI.GetRGB(255, 0, 0); //red
            int color2 = ChromaAnimationAPI.GetRGB(0, 255, 0); //green
                                                               //integer number of times to transition during animation
            int speed = 2;
            // loop over all frames in the layer
            for (int frameId = 0; frameId < frameCount; ++frameId)
            {
                //Math.cos gives a smooth 1 to 0 to 1 curve
                float t = (float)Math.Cos(speed * Math.PI * (frameId + 1) / (float)frameCount);
                // use t to transition from color 1 to color 2
                int color = ChromaAnimationAPI.LerpColor(color1, color2, t);
                // give color to the layer
                ChromaAnimationAPI.MultiplyIntensityColorName(baseLayer, frameId, color);
            }
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect16()
        {
            // start with a blank animation
            string baseLayer = "Animations/Tongue1_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect16ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/Tongue1_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect16Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/Tongue1_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect16Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/Tongue1_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect16Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/Tongue1_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect17()
        {
            // start with a blank animation
            string baseLayer = "Animations/Tongue1_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
            // loop over all frames in the layer
            for (int frameId = 0; frameId < frameCount; ++frameId)
            {
                int threshold = 100;
                // give color to the layer
                ChromaAnimationAPI.FillThresholdColorsRGBName(baseLayer, frameId, threshold, 255, 0, 0);
            }
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect17ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/Tongue1_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
            // loop over all frames in the layer
            for (int frameId = 0; frameId < frameCount; ++frameId)
            {
                int threshold = 100;
                // give color to the layer
                ChromaAnimationAPI.FillThresholdColorsRGBName(baseLayer, frameId, threshold, 255, 0, 0);
            }
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect17Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/Tongue1_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
            // loop over all frames in the layer
            for (int frameId = 0; frameId < frameCount; ++frameId)
            {
                int threshold = 100;
                // give color to the layer
                ChromaAnimationAPI.FillThresholdColorsRGBName(baseLayer, frameId, threshold, 255, 0, 0);
            }
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect17Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/Tongue1_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
            // loop over all frames in the layer
            for (int frameId = 0; frameId < frameCount; ++frameId)
            {
                int threshold = 100;
                // give color to the layer
                ChromaAnimationAPI.FillThresholdColorsRGBName(baseLayer, frameId, threshold, 255, 0, 0);
            }
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect17Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/Tongue1_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(baseLayer);
            // loop over all frames in the layer
            for (int frameId = 0; frameId < frameCount; ++frameId)
            {
                int threshold = 100;
                // give color to the layer
                ChromaAnimationAPI.FillThresholdColorsRGBName(baseLayer, frameId, threshold, 255, 0, 0);
            }
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect18()
        {
            // start with a blank animation
            string baseLayer = "Animations/Tongue1_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int threshold = 50;
            ChromaAnimationAPI.FillThresholdColorsAllFramesRGBName(baseLayer, threshold, 0, 64, 0); //dark green
                                                                                                    // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect18ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/Tongue1_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int threshold = 50;
            ChromaAnimationAPI.FillThresholdColorsAllFramesRGBName(baseLayer, threshold, 0, 64, 0); //dark green
                                                                                                    // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect18Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/Tongue1_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int threshold = 50;
            ChromaAnimationAPI.FillThresholdColorsAllFramesRGBName(baseLayer, threshold, 0, 64, 0); //dark green
                                                                                                    // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect18Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/Tongue1_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int threshold = 50;
            ChromaAnimationAPI.FillThresholdColorsAllFramesRGBName(baseLayer, threshold, 0, 64, 0); //dark green
                                                                                                    // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect18Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/Tongue1_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int threshold = 50;
            ChromaAnimationAPI.FillThresholdColorsAllFramesRGBName(baseLayer, threshold, 0, 64, 0); //dark green
                                                                                                    // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect19()
        {
            // start with a blank animation
            string baseLayer = "Animations/Tongue1_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int minThreshold = 50; //dark cyan
            int maxThreshold = 150; //purple
            ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 0, 63, 63, maxThreshold, 127, 0, 127);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect19ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/Tongue1_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int minThreshold = 50; //dark cyan
            int maxThreshold = 150; //purple
            ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 0, 63, 63, maxThreshold, 127, 0, 127);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect19Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/Tongue1_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int minThreshold = 50; //dark cyan
            int maxThreshold = 150; //purple
            ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 0, 63, 63, maxThreshold, 127, 0, 127);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect19Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/Tongue1_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int minThreshold = 50; //dark cyan
            int maxThreshold = 150; //purple
            ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 0, 63, 63, maxThreshold, 127, 0, 127);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect19Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/Tongue1_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int minThreshold = 50; //dark cyan
            int maxThreshold = 150; //purple
            ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 0, 63, 63, maxThreshold, 127, 0, 127);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect20()
        {
            // start with a blank animation
            string baseLayer = "Animations/Arc3_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect20ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/Arc3_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect20Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/Arc3_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect20Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/Arc3_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect20Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/Arc3_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect21()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Keyboard.chroma";
            string layer2 = "Animations/Arc3_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            ChromaAnimationAPI.CloseAnimationName(layer2);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            ChromaAnimationAPI.GetAnimation(layer2);
            int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
            // copy non zero colors from layer 2 to the base layer
            ChromaAnimationAPI.CopyNonZeroAllKeysAllFramesName(layer2, baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect21ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_ChromaLink.chroma";
            string layer2 = "Animations/Arc3_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            ChromaAnimationAPI.CloseAnimationName(layer2);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            ChromaAnimationAPI.GetAnimation(layer2);
            int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
            // copy non zero colors from layer 2 to the base layer
            ChromaAnimationAPI.CopyNonZeroAllKeysAllFramesName(layer2, baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect21Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Headset.chroma";
            string layer2 = "Animations/Arc3_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            ChromaAnimationAPI.CloseAnimationName(layer2);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            ChromaAnimationAPI.GetAnimation(layer2);
            int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
            // copy non zero colors from layer 2 to the base layer
            ChromaAnimationAPI.CopyNonZeroAllKeysAllFramesName(layer2, baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect21Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Mousepad.chroma";
            string layer2 = "Animations/Arc3_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            ChromaAnimationAPI.CloseAnimationName(layer2);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            ChromaAnimationAPI.GetAnimation(layer2);
            int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
            // copy non zero colors from layer 2 to the base layer
            ChromaAnimationAPI.CopyNonZeroAllKeysAllFramesName(layer2, baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect21Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Mouse.chroma";
            string layer2 = "Animations/Arc3_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            ChromaAnimationAPI.CloseAnimationName(layer2);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            ChromaAnimationAPI.GetAnimation(layer2);
            int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
            // copy non zero colors from layer 2 to the base layer
            ChromaAnimationAPI.CopyNonZeroAllKeysAllFramesName(layer2, baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect22()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Keyboard.chroma";
            string layer2 = "Animations/Arc3_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            ChromaAnimationAPI.CloseAnimationName(layer2);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            ChromaAnimationAPI.GetAnimation(layer2);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
            // setup background color on the base layer
            int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
            // replace darker colors with background color
            ChromaAnimationAPI.FillThresholdColorsAllFramesName(layer2, 64, background);
            // copy non zero colors from layer 2 to the base layer
            ChromaAnimationAPI.CopyNonZeroAllKeysAllFramesName(layer2, baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect22ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_ChromaLink.chroma";
            string layer2 = "Animations/Arc3_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            ChromaAnimationAPI.CloseAnimationName(layer2);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            ChromaAnimationAPI.GetAnimation(layer2);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
            // setup background color on the base layer
            int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
            // replace darker colors with background color
            ChromaAnimationAPI.FillThresholdColorsAllFramesName(layer2, 64, background);
            // copy non zero colors from layer 2 to the base layer
            ChromaAnimationAPI.CopyNonZeroAllKeysAllFramesName(layer2, baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect22Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Headset.chroma";
            string layer2 = "Animations/Arc3_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            ChromaAnimationAPI.CloseAnimationName(layer2);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            ChromaAnimationAPI.GetAnimation(layer2);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
            // setup background color on the base layer
            int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
            // replace darker colors with background color
            ChromaAnimationAPI.FillThresholdColorsAllFramesName(layer2, 64, background);
            // copy non zero colors from layer 2 to the base layer
            ChromaAnimationAPI.CopyNonZeroAllKeysAllFramesName(layer2, baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect22Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Mousepad.chroma";
            string layer2 = "Animations/Arc3_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            ChromaAnimationAPI.CloseAnimationName(layer2);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            ChromaAnimationAPI.GetAnimation(layer2);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
            // setup background color on the base layer
            int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
            // replace darker colors with background color
            ChromaAnimationAPI.FillThresholdColorsAllFramesName(layer2, 64, background);
            // copy non zero colors from layer 2 to the base layer
            ChromaAnimationAPI.CopyNonZeroAllKeysAllFramesName(layer2, baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect22Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Mouse.chroma";
            string layer2 = "Animations/Arc3_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            ChromaAnimationAPI.CloseAnimationName(layer2);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            ChromaAnimationAPI.GetAnimation(layer2);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
            // setup background color on the base layer
            int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
            // replace darker colors with background color
            ChromaAnimationAPI.FillThresholdColorsAllFramesName(layer2, 64, background);
            // copy non zero colors from layer 2 to the base layer
            ChromaAnimationAPI.CopyNonZeroAllKeysAllFramesName(layer2, baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect23()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Keyboard.chroma";
            string layer2 = "Animations/Arc3_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            ChromaAnimationAPI.CloseAnimationName(layer2);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            ChromaAnimationAPI.GetAnimation(layer2);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
            // setup background color on the base layer
            int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
            // Add non zero colors from layer 2 to the base layer
            ChromaAnimationAPI.AddNonZeroAllKeysAllFramesName(layer2, baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect23ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_ChromaLink.chroma";
            string layer2 = "Animations/Arc3_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            ChromaAnimationAPI.CloseAnimationName(layer2);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            ChromaAnimationAPI.GetAnimation(layer2);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
            // setup background color on the base layer
            int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
            // Add non zero colors from layer 2 to the base layer
            ChromaAnimationAPI.AddNonZeroAllKeysAllFramesName(layer2, baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect23Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Headset.chroma";
            string layer2 = "Animations/Arc3_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            ChromaAnimationAPI.CloseAnimationName(layer2);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            ChromaAnimationAPI.GetAnimation(layer2);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
            // setup background color on the base layer
            int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
            // Add non zero colors from layer 2 to the base layer
            ChromaAnimationAPI.AddNonZeroAllKeysAllFramesName(layer2, baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect23Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Mousepad.chroma";
            string layer2 = "Animations/Arc3_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            ChromaAnimationAPI.CloseAnimationName(layer2);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            ChromaAnimationAPI.GetAnimation(layer2);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
            // setup background color on the base layer
            int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
            // Add non zero colors from layer 2 to the base layer
            ChromaAnimationAPI.AddNonZeroAllKeysAllFramesName(layer2, baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect23Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Mouse.chroma";
            string layer2 = "Animations/Arc3_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            ChromaAnimationAPI.CloseAnimationName(layer2);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            ChromaAnimationAPI.GetAnimation(layer2);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
            // setup background color on the base layer
            int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
            // Add non zero colors from layer 2 to the base layer
            ChromaAnimationAPI.AddNonZeroAllKeysAllFramesName(layer2, baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect24()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Keyboard.chroma";
            string layer2 = "Animations/Arc3_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            ChromaAnimationAPI.CloseAnimationName(layer2);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            ChromaAnimationAPI.GetAnimation(layer2);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
            // setup background color on the base layer
            int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
            // Add non zero colors from layer 2 to the base layer
            ChromaAnimationAPI.SubtractNonZeroAllKeysAllFramesName(layer2, baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect24ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_ChromaLink.chroma";
            string layer2 = "Animations/Arc3_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            ChromaAnimationAPI.CloseAnimationName(layer2);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            ChromaAnimationAPI.GetAnimation(layer2);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
            // setup background color on the base layer
            int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
            // Add non zero colors from layer 2 to the base layer
            ChromaAnimationAPI.SubtractNonZeroAllKeysAllFramesName(layer2, baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect24Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Headset.chroma";
            string layer2 = "Animations/Arc3_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            ChromaAnimationAPI.CloseAnimationName(layer2);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            ChromaAnimationAPI.GetAnimation(layer2);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
            // setup background color on the base layer
            int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
            // Add non zero colors from layer 2 to the base layer
            ChromaAnimationAPI.SubtractNonZeroAllKeysAllFramesName(layer2, baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect24Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Mousepad.chroma";
            string layer2 = "Animations/Arc3_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            ChromaAnimationAPI.CloseAnimationName(layer2);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            ChromaAnimationAPI.GetAnimation(layer2);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
            // setup background color on the base layer
            int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
            // Add non zero colors from layer 2 to the base layer
            ChromaAnimationAPI.SubtractNonZeroAllKeysAllFramesName(layer2, baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect24Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Mouse.chroma";
            string layer2 = "Animations/Arc3_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            ChromaAnimationAPI.CloseAnimationName(layer2);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            ChromaAnimationAPI.GetAnimation(layer2);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
            // setup background color on the base layer
            int background = ChromaAnimationAPI.GetRGB(127, 0, 0);
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, background);
            // Add non zero colors from layer 2 to the base layer
            ChromaAnimationAPI.SubtractNonZeroAllKeysAllFramesName(layer2, baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect25()
        {
            // start with a blank animation
            string baseLayer = "Animations/CircleSmall_Keyboard.chroma";
            string layer2 = "animations/Rainbow_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            ChromaAnimationAPI.CloseAnimationName(layer2);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            ChromaAnimationAPI.GetAnimation(layer2);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
            ChromaAnimationAPI.DuplicateFirstFrameName(baseLayer, frameCount);
            // copy non zero colors from layer 2 to the base layer where the base layer was non zero
            ChromaAnimationAPI.CopyNonZeroTargetAllKeysAllFramesName(layer2, baseLayer);
            // set a background color
            ChromaAnimationAPI.FillZeroColorAllFramesRGBName(baseLayer, 255, 0, 0);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect25ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/CircleSmall_ChromaLink.chroma";
            string layer2 = "animations/Rainbow_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            ChromaAnimationAPI.CloseAnimationName(layer2);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            ChromaAnimationAPI.GetAnimation(layer2);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
            ChromaAnimationAPI.DuplicateFirstFrameName(baseLayer, frameCount);
            // copy non zero colors from layer 2 to the base layer where the base layer was non zero
            ChromaAnimationAPI.CopyNonZeroTargetAllKeysAllFramesName(layer2, baseLayer);
            // set a background color
            ChromaAnimationAPI.FillZeroColorAllFramesRGBName(baseLayer, 255, 0, 0);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect25Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/CircleSmall_Headset.chroma";
            string layer2 = "animations/Rainbow_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            ChromaAnimationAPI.CloseAnimationName(layer2);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            ChromaAnimationAPI.GetAnimation(layer2);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
            ChromaAnimationAPI.DuplicateFirstFrameName(baseLayer, frameCount);
            // copy non zero colors from layer 2 to the base layer where the base layer was non zero
            ChromaAnimationAPI.CopyNonZeroTargetAllKeysAllFramesName(layer2, baseLayer);
            // set a background color
            ChromaAnimationAPI.FillZeroColorAllFramesRGBName(baseLayer, 255, 0, 0);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect25Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/CircleSmall_Mousepad.chroma";
            string layer2 = "animations/Rainbow_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            ChromaAnimationAPI.CloseAnimationName(layer2);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            ChromaAnimationAPI.GetAnimation(layer2);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
            ChromaAnimationAPI.DuplicateFirstFrameName(baseLayer, frameCount);
            // copy non zero colors from layer 2 to the base layer where the base layer was non zero
            ChromaAnimationAPI.CopyNonZeroTargetAllKeysAllFramesName(layer2, baseLayer);
            // set a background color
            ChromaAnimationAPI.FillZeroColorAllFramesRGBName(baseLayer, 255, 0, 0);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect25Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/CircleSmall_Mouse.chroma";
            string layer2 = "animations/Rainbow_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            ChromaAnimationAPI.CloseAnimationName(layer2);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            ChromaAnimationAPI.GetAnimation(layer2);
            int frameCount = ChromaAnimationAPI.GetFrameCountName(layer2);
            ChromaAnimationAPI.DuplicateFirstFrameName(baseLayer, frameCount);
            // copy non zero colors from layer 2 to the base layer where the base layer was non zero
            ChromaAnimationAPI.CopyNonZeroTargetAllKeysAllFramesName(layer2, baseLayer);
            // set a background color
            ChromaAnimationAPI.FillZeroColorAllFramesRGBName(baseLayer, 255, 0, 0);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect26()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect26ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect26Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect26Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect26Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect27()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect27ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect27Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect27Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect27Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect28()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // reverse the order of frames
            ChromaAnimationAPI.ReverseAllFramesName(baseLayer);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect28ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // reverse the order of frames
            ChromaAnimationAPI.ReverseAllFramesName(baseLayer);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect28Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // reverse the order of frames
            ChromaAnimationAPI.ReverseAllFramesName(baseLayer);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect28Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // reverse the order of frames
            ChromaAnimationAPI.ReverseAllFramesName(baseLayer);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect28Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // reverse the order of frames
            ChromaAnimationAPI.ReverseAllFramesName(baseLayer);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect29()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // invert all the animation colors
            ChromaAnimationAPI.InvertColorsAllFramesName(baseLayer);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect29ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // invert all the animation colors
            ChromaAnimationAPI.InvertColorsAllFramesName(baseLayer);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect29Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // invert all the animation colors
            ChromaAnimationAPI.InvertColorsAllFramesName(baseLayer);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect29Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // invert all the animation colors
            ChromaAnimationAPI.InvertColorsAllFramesName(baseLayer);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect29Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // invert all the animation colors
            ChromaAnimationAPI.InvertColorsAllFramesName(baseLayer);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect30()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // duplicate and mirror
            ChromaAnimationAPI.DuplicateMirrorFramesName(baseLayer);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect30ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // duplicate and mirror
            ChromaAnimationAPI.DuplicateMirrorFramesName(baseLayer);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect30Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // duplicate and mirror
            ChromaAnimationAPI.DuplicateMirrorFramesName(baseLayer);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect30Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // duplicate and mirror
            ChromaAnimationAPI.DuplicateMirrorFramesName(baseLayer);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect30Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // duplicate and mirror
            ChromaAnimationAPI.DuplicateMirrorFramesName(baseLayer);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect31()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // insert a pause
            int frameId = 50;
            int delay = 20;
            ChromaAnimationAPI.InsertDelayName(baseLayer, frameId, delay);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect31ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // insert a pause
            int frameId = 50;
            int delay = 20;
            ChromaAnimationAPI.InsertDelayName(baseLayer, frameId, delay);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect31Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // insert a pause
            int frameId = 50;
            int delay = 20;
            ChromaAnimationAPI.InsertDelayName(baseLayer, frameId, delay);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect31Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // insert a pause
            int frameId = 50;
            int delay = 20;
            ChromaAnimationAPI.InsertDelayName(baseLayer, frameId, delay);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect31Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // insert a pause
            int frameId = 50;
            int delay = 20;
            ChromaAnimationAPI.InsertDelayName(baseLayer, frameId, delay);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect32()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // reduce half of the frames, remove every 2nd frame
            ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect32ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // reduce half of the frames, remove every 2nd frame
            ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect32Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // reduce half of the frames, remove every 2nd frame
            ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect32Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // reduce half of the frames, remove every 2nd frame
            ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect32Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // reduce half of the frames, remove every 2nd frame
            ChromaAnimationAPI.ReduceFramesName(baseLayer, 2);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect33()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // double the number of the frames
            ChromaAnimationAPI.DuplicateFramesName(baseLayer);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect33ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // double the number of the frames
            ChromaAnimationAPI.DuplicateFramesName(baseLayer);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect33Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // double the number of the frames
            ChromaAnimationAPI.DuplicateFramesName(baseLayer);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect33Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // double the number of the frames
            ChromaAnimationAPI.DuplicateFramesName(baseLayer);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect33Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // double the number of the frames
            ChromaAnimationAPI.DuplicateFramesName(baseLayer);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect34()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // trim the start of the animation, so it starts at frame 10
            ChromaAnimationAPI.TrimStartFramesName(baseLayer, 10);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect34ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // trim the start of the animation, so it starts at frame 10
            ChromaAnimationAPI.TrimStartFramesName(baseLayer, 10);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect34Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // trim the start of the animation, so it starts at frame 10
            ChromaAnimationAPI.TrimStartFramesName(baseLayer, 10);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect34Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // trim the start of the animation, so it starts at frame 10
            ChromaAnimationAPI.TrimStartFramesName(baseLayer, 10);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect34Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // trim the start of the animation, so it starts at frame 10
            ChromaAnimationAPI.TrimStartFramesName(baseLayer, 10);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect35()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // trim the start of the animation, so it starts at frame 10
            ChromaAnimationAPI.TrimStartFramesName(baseLayer, 10);
            // trim the end of the animation
            ChromaAnimationAPI.TrimEndFramesName(baseLayer, 75);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect35ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // trim the start of the animation, so it starts at frame 10
            ChromaAnimationAPI.TrimStartFramesName(baseLayer, 10);
            // trim the end of the animation
            ChromaAnimationAPI.TrimEndFramesName(baseLayer, 75);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect35Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // trim the start of the animation, so it starts at frame 10
            ChromaAnimationAPI.TrimStartFramesName(baseLayer, 10);
            // trim the end of the animation
            ChromaAnimationAPI.TrimEndFramesName(baseLayer, 75);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect35Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // trim the start of the animation, so it starts at frame 10
            ChromaAnimationAPI.TrimStartFramesName(baseLayer, 10);
            // trim the end of the animation
            ChromaAnimationAPI.TrimEndFramesName(baseLayer, 75);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect35Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/MovementUpLeft_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // trim the start of the animation, so it starts at frame 10
            ChromaAnimationAPI.TrimStartFramesName(baseLayer, 10);
            // trim the end of the animation
            ChromaAnimationAPI.TrimEndFramesName(baseLayer, 75);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect36()
        {
            // start with a blank animation
            string baseLayer = "Animations/CircleSmall_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = 20;
            ChromaAnimationAPI.DuplicateFirstFrameName(baseLayer, frameCount);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect36ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/CircleSmall_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = 20;
            ChromaAnimationAPI.DuplicateFirstFrameName(baseLayer, frameCount);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect36Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/CircleSmall_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = 20;
            ChromaAnimationAPI.DuplicateFirstFrameName(baseLayer, frameCount);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect36Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/CircleSmall_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = 20;
            ChromaAnimationAPI.DuplicateFirstFrameName(baseLayer, frameCount);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect36Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/CircleSmall_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = 20;
            ChromaAnimationAPI.DuplicateFirstFrameName(baseLayer, frameCount);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect37()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = 20;
            // Start with blank frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
            // Fill all frames with black and white static
            ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
            // slow down the random frames so it can be seen
            ChromaAnimationAPI.DuplicateFramesName(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect37ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = 20;
            // Start with blank frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
            // Fill all frames with black and white static
            ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
            // slow down the random frames so it can be seen
            ChromaAnimationAPI.DuplicateFramesName(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect37Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = 20;
            // Start with blank frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
            // Fill all frames with black and white static
            ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
            // slow down the random frames so it can be seen
            ChromaAnimationAPI.DuplicateFramesName(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect37Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = 20;
            // Start with blank frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
            // Fill all frames with black and white static
            ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
            // slow down the random frames so it can be seen
            ChromaAnimationAPI.DuplicateFramesName(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect37Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = 20;
            // Start with blank frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
            // Fill all frames with black and white static
            ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
            // slow down the random frames so it can be seen
            ChromaAnimationAPI.DuplicateFramesName(baseLayer);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect38()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = 20;
            // Start with blank frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
            // Fill all frames with black and white static
            ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
            // slow down the random frames so it can be seen
            ChromaAnimationAPI.DuplicateFramesName(baseLayer);
            // make random colors more sparse using threshold
            int threshold = 240;
            // turn lower intensity colors to black
            ChromaAnimationAPI.FillThresholdColorsAllFramesName(baseLayer, threshold, 0);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect38ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = 20;
            // Start with blank frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
            // Fill all frames with black and white static
            ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
            // slow down the random frames so it can be seen
            ChromaAnimationAPI.DuplicateFramesName(baseLayer);
            // make random colors more sparse using threshold
            int threshold = 240;
            // turn lower intensity colors to black
            ChromaAnimationAPI.FillThresholdColorsAllFramesName(baseLayer, threshold, 0);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect38Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = 20;
            // Start with blank frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
            // Fill all frames with black and white static
            ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
            // slow down the random frames so it can be seen
            ChromaAnimationAPI.DuplicateFramesName(baseLayer);
            // make random colors more sparse using threshold
            int threshold = 240;
            // turn lower intensity colors to black
            ChromaAnimationAPI.FillThresholdColorsAllFramesName(baseLayer, threshold, 0);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect38Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = 20;
            // Start with blank frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
            // Fill all frames with black and white static
            ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
            // slow down the random frames so it can be seen
            ChromaAnimationAPI.DuplicateFramesName(baseLayer);
            // make random colors more sparse using threshold
            int threshold = 240;
            // turn lower intensity colors to black
            ChromaAnimationAPI.FillThresholdColorsAllFramesName(baseLayer, threshold, 0);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect38Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = 20;
            // Start with blank frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
            // Fill all frames with black and white static
            ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
            // slow down the random frames so it can be seen
            ChromaAnimationAPI.DuplicateFramesName(baseLayer);
            // make random colors more sparse using threshold
            int threshold = 240;
            // turn lower intensity colors to black
            ChromaAnimationAPI.FillThresholdColorsAllFramesName(baseLayer, threshold, 0);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect39()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = 20;
            // Start with blank frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
            // Fill all frames with black and white static
            ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
            // slow down the random frames so it can be seen
            ChromaAnimationAPI.DuplicateFramesName(baseLayer);
            int minThreshold = 240; //black
            int maxThreshold = 240; //rain
            ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 0, 0, 0, maxThreshold, 0, 127, 255);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect39ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = 20;
            // Start with blank frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
            // Fill all frames with black and white static
            ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
            // slow down the random frames so it can be seen
            ChromaAnimationAPI.DuplicateFramesName(baseLayer);
            int minThreshold = 240; //black
            int maxThreshold = 240; //rain
            ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 0, 0, 0, maxThreshold, 0, 127, 255);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect39Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = 20;
            // Start with blank frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
            // Fill all frames with black and white static
            ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
            // slow down the random frames so it can be seen
            ChromaAnimationAPI.DuplicateFramesName(baseLayer);
            int minThreshold = 240; //black
            int maxThreshold = 240; //rain
            ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 0, 0, 0, maxThreshold, 0, 127, 255);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect39Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = 20;
            // Start with blank frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
            // Fill all frames with black and white static
            ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
            // slow down the random frames so it can be seen
            ChromaAnimationAPI.DuplicateFramesName(baseLayer);
            int minThreshold = 240; //black
            int maxThreshold = 240; //rain
            ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 0, 0, 0, maxThreshold, 0, 127, 255);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect39Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            int frameCount = 20;
            // Start with blank frames set to 30FPS
            ChromaAnimationAPI.MakeBlankFramesName(baseLayer, frameCount, 0.033f, 0);
            // Fill all frames with black and white static
            ChromaAnimationAPI.FillRandomColorsBlackAndWhiteAllFramesName(baseLayer);
            // slow down the random frames so it can be seen
            ChromaAnimationAPI.DuplicateFramesName(baseLayer);
            int minThreshold = 240; //black
            int maxThreshold = 240; //rain
            ChromaAnimationAPI.FillThresholdColorsMinMaxAllFramesRGBName(baseLayer, minThreshold, 0, 0, 0, maxThreshold, 0, 127, 255);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
        void ShowEffect40()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Keyboard.chroma";
            string idleAnimation = "Animations/BlackAndWhiteRainbow_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            ChromaAnimationAPI.CloseAnimationName(idleAnimation);
            // Set idle animation
            ChromaAnimationAPI.SetIdleAnimationName(idleAnimation);
            // Enable idle animation
            ChromaAnimationAPI.UseIdleAnimation((int)ChromaAnimationAPI.Device.Keyboard, true);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // Transition from green to red and then stop
            int frameCount = 30;
            ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.1f, 255, 255, 255);
            int color1 = ChromaAnimationAPI.GetRGB(0, 255, 0);
            int color2 = ChromaAnimationAPI.GetRGB(255, 0, 0);
            ChromaAnimationAPI.MultiplyColorLerpAllFramesName(baseLayer, color1, color2);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, false);
        }
        void ShowEffect40ChromaLink()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_ChromaLink.chroma";
            string idleAnimation = "Animations/BlackAndWhiteRainbow_ChromaLink.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            ChromaAnimationAPI.CloseAnimationName(idleAnimation);
            // Set idle animation
            ChromaAnimationAPI.SetIdleAnimationName(idleAnimation);
            // Enable idle animation
            ChromaAnimationAPI.UseIdleAnimation((int)ChromaAnimationAPI.Device.ChromaLink, true);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // Transition from green to red and then stop
            int frameCount = 30;
            ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.1f, 255, 255, 255);
            int color1 = ChromaAnimationAPI.GetRGB(0, 255, 0);
            int color2 = ChromaAnimationAPI.GetRGB(255, 0, 0);
            ChromaAnimationAPI.MultiplyColorLerpAllFramesName(baseLayer, color1, color2);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, false);
        }
        void ShowEffect40Headset()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Headset.chroma";
            string idleAnimation = "Animations/BlackAndWhiteRainbow_Headset.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            ChromaAnimationAPI.CloseAnimationName(idleAnimation);
            // Set idle animation
            ChromaAnimationAPI.SetIdleAnimationName(idleAnimation);
            // Enable idle animation
            ChromaAnimationAPI.UseIdleAnimation((int)ChromaAnimationAPI.Device.Headset, true);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // Transition from green to red and then stop
            int frameCount = 30;
            ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.1f, 255, 255, 255);
            int color1 = ChromaAnimationAPI.GetRGB(0, 255, 0);
            int color2 = ChromaAnimationAPI.GetRGB(255, 0, 0);
            ChromaAnimationAPI.MultiplyColorLerpAllFramesName(baseLayer, color1, color2);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, false);
        }
        void ShowEffect40Mousepad()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Mousepad.chroma";
            string idleAnimation = "Animations/BlackAndWhiteRainbow_Mousepad.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            ChromaAnimationAPI.CloseAnimationName(idleAnimation);
            // Set idle animation
            ChromaAnimationAPI.SetIdleAnimationName(idleAnimation);
            // Enable idle animation
            ChromaAnimationAPI.UseIdleAnimation((int)ChromaAnimationAPI.Device.Mousepad, true);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // Transition from green to red and then stop
            int frameCount = 30;
            ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.1f, 255, 255, 255);
            int color1 = ChromaAnimationAPI.GetRGB(0, 255, 0);
            int color2 = ChromaAnimationAPI.GetRGB(255, 0, 0);
            ChromaAnimationAPI.MultiplyColorLerpAllFramesName(baseLayer, color1, color2);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, false);
        }
        void ShowEffect40Mouse()
        {
            // start with a blank animation
            string baseLayer = "Animations/Blank_Mouse.chroma";
            string idleAnimation = "Animations/BlackAndWhiteRainbow_Mouse.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            ChromaAnimationAPI.CloseAnimationName(idleAnimation);
            // Set idle animation
            ChromaAnimationAPI.SetIdleAnimationName(idleAnimation);
            // Enable idle animation
            ChromaAnimationAPI.UseIdleAnimation((int)ChromaAnimationAPI.Device.Mouse, true);
            // open the blank animation, passing a reference to the base animation when loading has completed
            ChromaAnimationAPI.GetAnimation(baseLayer);
            // Transition from green to red and then stop
            int frameCount = 30;
            ChromaAnimationAPI.MakeBlankFramesRGBName(baseLayer, frameCount, 0.1f, 255, 255, 255);
            int color1 = ChromaAnimationAPI.GetRGB(0, 255, 0);
            int color2 = ChromaAnimationAPI.GetRGB(255, 0, 0);
            ChromaAnimationAPI.MultiplyColorLerpAllFramesName(baseLayer, color1, color2);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, false);
        }
        #endregion

    }    
}
