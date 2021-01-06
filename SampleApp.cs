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
                case 47:
                    ShowEffect47();
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

        #region Embedded Effects

        public static readonly byte[] EMBED_ARC1_KEYBOARD = { 1, 0, 0, 0, 1, 0, 49, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 157, 156, 157, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 141, 138, 141, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 136, 135, 136, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 136, 135, 136, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 120, 119, 120, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 39, 39, 40, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 3, 3, 0, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 1, 1, 1, 0, 0, 0, 0, 0, 2, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 6, 6, 0, 2, 3, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 14, 14, 14, 0, 3, 2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 14, 14, 14, 0, 15, 16, 16, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 4, 4, 4, 0, 0, 0, 0, 0, 11, 10, 11, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 20, 21, 20, 0, 13, 13, 13, 0, 2, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 38, 38, 38, 0, 14, 14, 14, 0, 0, 0, 0, 0, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 33, 33, 34, 0, 37, 37, 37, 0, 6, 6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 10, 10, 10, 0, 0, 0, 0, 0, 27, 27, 27, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 4, 3, 0, 6, 6, 6, 0, 6, 6, 6, 0, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 41, 41, 41, 0, 35, 36, 35, 0, 14, 14, 14, 0, 6, 7, 7, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 74, 75, 75, 0, 37, 37, 37, 0, 0, 0, 0, 0, 30, 30, 30, 0, 9, 9, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 59, 59, 59, 0, 65, 65, 65, 0, 16, 15, 16, 0, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 14, 14, 14, 0, 0, 0, 0, 0, 51, 51, 51, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 6, 6, 0, 16, 16, 16, 0, 19, 19, 19, 0, 18, 18, 18, 0, 19, 19, 19, 0, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 67, 67, 66, 0, 69, 68, 68, 0, 39, 40, 39, 0, 25, 25, 25, 0, 8, 8, 8, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 123, 123, 124, 0, 71, 71, 71, 0, 0, 0, 0, 0, 84, 83, 83, 0, 44, 44, 44, 0, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 88, 88, 88, 0, 95, 95, 95, 0, 28, 28, 28, 0, 15, 15, 15, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 14, 14, 14, 0, 0, 0, 0, 0, 75, 75, 75, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 4, 4, 3, 0, 5, 5, 5, 0, 8, 8, 8, 0, 1, 1, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 7, 7, 7, 0, 27, 27, 27, 0, 38, 38, 38, 0, 41, 41, 40, 0, 25, 25, 25, 0, 31, 31, 31, 0, 3, 3, 3, 0, 2, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 88, 88, 87, 0, 107, 107, 107, 0, 76, 77, 77, 0, 55, 55, 55, 0, 24, 25, 25, 0, 16, 18, 19, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 173, 173, 174, 0, 110, 109, 109, 0, 0, 0, 0, 0, 149, 149, 150, 0, 101, 101, 100, 0, 14, 15, 15, 0, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 109, 110, 109, 0, 116, 116, 116, 0, 37, 37, 37, 0, 23, 23, 24, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 13, 13, 13, 0, 0, 0, 0, 0, 85, 85, 85, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 5, 5, 5, 0, 8, 8, 8, 0, 16, 16, 16, 0, 4, 4, 4, 0, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 7, 7, 7, 0, 32, 31, 31, 0, 49, 48, 49, 0, 53, 53, 53, 0, 36, 36, 36, 0, 51, 50, 50, 0, 8, 8, 8, 0, 11, 11, 11, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 94, 94, 94, 0, 127, 127, 127, 0, 97, 97, 97, 0, 73, 73, 73, 0, 35, 35, 35, 0, 32, 32, 32, 0, 3, 3, 3, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 197, 197, 197, 0, 128, 128, 128, 0, 0, 0, 0, 0, 178, 178, 178, 0, 130, 130, 129, 0, 23, 23, 23, 0, 6, 6, 6, 0, 2, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 114, 113, 113, 0, 122, 121, 121, 0, 40, 40, 39, 0, 27, 26, 27, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 8, 8, 8, 0, 0, 0, 0, 0, 98, 98, 97, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 8, 8, 8, 0, 18, 18, 18, 0, 51, 51, 51, 0, 17, 18, 17, 0, 38, 37, 38, 0, 21, 21, 21, 0, 12, 12, 12, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 4, 4, 0, 37, 37, 37, 0, 70, 70, 71, 0, 86, 86, 86, 0, 74, 74, 74, 0, 121, 122, 121, 0, 31, 31, 31, 0, 57, 57, 57, 0, 27, 27, 27, 0, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 97, 97, 97, 0, 163, 163, 162, 0, 149, 149, 150, 0, 122, 122, 121, 0, 71, 71, 71, 0, 84, 84, 84, 0, 15, 15, 15, 0, 20, 20, 20, 0, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 239, 240, 239, 0, 163, 162, 163, 0, 0, 0, 0, 0, 143, 143, 143, 0, 193, 193, 193, 0, 51, 51, 51, 0, 23, 23, 23, 0, 11, 11, 11, 0, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 111, 111, 111, 0, 118, 118, 118, 0, 39, 39, 39, 0, 27, 27, 27, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 6, 6, 6, 0, 0, 0, 0, 0, 98, 98, 98, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 8, 8, 8, 0, 21, 21, 21, 0, 63, 63, 63, 0, 23, 23, 23, 0, 50, 50, 50, 0, 31, 31, 31, 0, 20, 20, 20, 0, 2, 3, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 3, 3, 0, 37, 37, 37, 0, 77, 76, 77, 0, 98, 98, 97, 0, 89, 89, 89, 0, 143, 144, 143, 0, 40, 40, 40, 0, 73, 74, 73, 0, 39, 38, 38, 0, 5, 5, 5, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 92, 93, 92, 0, 173, 173, 173, 0, 170, 170, 171, 0, 140, 141, 140, 0, 85, 85, 85, 0, 101, 101, 101, 0, 19, 19, 19, 0, 27, 27, 27, 0, 7, 7, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 244, 245, 245, 0, 172, 172, 172, 0, 0, 0, 0, 0, 163, 163, 163, 0, 210, 210, 210, 0, 62, 62, 62, 0, 30, 30, 30, 0, 15, 15, 15, 0, 6, 6, 6, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 103, 103, 103, 0, 109, 109, 109, 0, 36, 35, 36, 0, 25, 25, 25, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 2, 2, 2, 0, 0, 0, 0, 0, 91, 91, 91, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 3, 3, 3, 0, 3, 3, 3, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 8, 8, 0, 28, 28, 28, 0, 99, 98, 98, 0, 42, 42, 42, 0, 100, 99, 101, 0, 79, 78, 78, 0, 62, 63, 63, 0, 14, 14, 14, 0, 5, 5, 5, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 32, 32, 32, 0, 84, 85, 84, 0, 120, 120, 120, 0, 129, 129, 129, 0, 201, 201, 200, 0, 76, 76, 77, 0, 138, 138, 138, 0, 96, 93, 93, 0, 20, 20, 20, 0, 9, 9, 9, 0, 3, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 76, 76, 76, 0, 179, 179, 179, 0, 215, 215, 215, 0, 184, 184, 184, 0, 119, 119, 120, 0, 152, 152, 152, 0, 37, 37, 37, 0, 63, 62, 62, 0, 30, 30, 30, 0, 3, 3, 3, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 219, 219, 219, 0, 175, 173, 174, 0, 0, 0, 0, 0, 208, 208, 208, 0, 157, 157, 157, 0, 93, 93, 93, 0, 52, 52, 52, 0, 32, 31, 31, 0, 17, 17, 17, 0, 7, 7, 7, 0, 2, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 80, 80, 80, 0, 85, 85, 85, 0, 25, 25, 25, 0, 15, 15, 15, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 69, 69, 70, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 2, 2, 0, 10, 10, 10, 0, 15, 14, 14, 0, 4, 4, 4, 0, 2, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 5, 4, 0, 29, 30, 29, 0, 124, 123, 123, 0, 64, 64, 64, 0, 70, 70, 71, 0, 130, 130, 130, 0, 117, 117, 117, 0, 34, 34, 34, 0, 17, 17, 17, 0, 8, 8, 9, 0, 2, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 21, 22, 21, 0, 79, 79, 79, 0, 129, 129, 129, 0, 168, 168, 167, 0, 237, 236, 238, 0, 120, 120, 121, 0, 194, 196, 195, 0, 153, 153, 153, 0, 44, 44, 43, 0, 25, 25, 25, 0, 12, 12, 12, 0, 3, 3, 3, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 49, 49, 49, 0, 161, 161, 161, 0, 243, 244, 244, 0, 215, 216, 215, 0, 150, 149, 149, 0, 187, 187, 187, 0, 57, 57, 56, 0, 96, 96, 98, 0, 57, 57, 57, 0, 9, 9, 10, 0, 4, 4, 4, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 169, 169, 169, 0, 152, 152, 152, 0, 0, 0, 0, 0, 237, 238, 237, 0, 187, 186, 187, 0, 120, 120, 120, 0, 74, 75, 74, 0, 48, 49, 49, 0, 30, 30, 30, 0, 16, 16, 16, 0, 7, 7, 8, 0, 7, 7, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 47, 47, 47, 0, 51, 51, 51, 0, 12, 12, 12, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 42, 42, 42, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 2, 2, 0, 15, 16, 14, 0, 8, 8, 8, 0, 8, 8, 8, 0, 5, 5, 5, 0, 3, 3, 3, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 25, 25, 25, 0, 133, 133, 133, 0, 81, 81, 80, 0, 93, 93, 92, 0, 172, 172, 173, 0, 77, 77, 77, 0, 56, 57, 57, 0, 35, 35, 35, 0, 21, 21, 21, 0, 9, 10, 10, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 9, 9, 9, 0, 62, 62, 62, 0, 120, 121, 120, 0, 190, 190, 190, 0, 251, 251, 251, 0, 162, 162, 162, 0, 229, 231, 229, 0, 199, 199, 198, 0, 71, 71, 71, 0, 45, 45, 45, 0, 25, 26, 26, 0, 10, 10, 10, 0, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 22, 22, 22, 0, 124, 124, 124, 0, 220, 220, 220, 0, 216, 216, 216, 0, 162, 163, 162, 0, 206, 207, 206, 0, 71, 70, 70, 0, 122, 122, 123, 0, 81, 81, 81, 0, 17, 17, 17, 0, 10, 9, 10, 0, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 116, 116, 116, 0, 113, 113, 114, 0, 0, 0, 0, 0, 222, 222, 222, 0, 193, 193, 193, 0, 135, 135, 135, 0, 90, 90, 90, 0, 63, 63, 62, 0, 42, 42, 42, 0, 25, 25, 25, 0, 14, 14, 15, 0, 20, 19, 19, 0, 2, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 18, 18, 19, 0, 21, 21, 21, 0, 2, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 19, 19, 19, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 17, 17, 17, 0, 12, 11, 12, 0, 14, 14, 14, 0, 13, 13, 13, 0, 11, 11, 11, 0, 7, 7, 8, 0, 7, 7, 7, 0, 2, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 15, 15, 14, 0, 126, 126, 126, 0, 90, 90, 90, 0, 113, 113, 113, 0, 121, 121, 121, 0, 119, 119, 119, 0, 100, 100, 100, 0, 76, 76, 76, 0, 56, 56, 57, 0, 36, 36, 36, 0, 36, 36, 36, 0, 3, 3, 3, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 38, 38, 38, 0, 95, 95, 95, 0, 188, 188, 188, 0, 255, 255, 255, 0, 215, 215, 215, 0, 250, 251, 252, 0, 239, 238, 238, 0, 117, 117, 117, 0, 87, 87, 87, 0, 60, 60, 60, 0, 34, 34, 34, 0, 24, 24, 24, 0, 20, 21, 21, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 6, 6, 0, 84, 84, 84, 0, 173, 173, 173, 0, 183, 183, 183, 0, 153, 153, 152, 0, 212, 212, 212, 0, 78, 79, 79, 0, 139, 140, 138, 0, 104, 104, 103, 0, 29, 29, 29, 0, 20, 20, 20, 0, 12, 12, 12, 0, 4, 4, 4, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 66, 66, 66, 0, 73, 73, 73, 0, 0, 0, 0, 0, 178, 178, 177, 0, 168, 168, 168, 0, 132, 132, 132, 0, 97, 97, 96, 0, 71, 71, 71, 0, 53, 53, 52, 0, 35, 35, 35, 0, 25, 25, 25, 0, 43, 42, 42, 0, 9, 9, 8, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 3, 3, 0, 3, 4, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 10, 10, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 16, 16, 16, 0, 12, 12, 12, 0, 16, 16, 16, 0, 15, 16, 16, 0, 14, 14, 14, 0, 10, 10, 10, 0, 11, 11, 11, 0, 2, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 11, 11, 10, 0, 116, 116, 117, 0, 89, 89, 89, 0, 115, 115, 115, 0, 130, 130, 130, 0, 131, 132, 131, 0, 113, 113, 114, 0, 89, 89, 90, 0, 68, 68, 68, 0, 46, 46, 46, 0, 48, 48, 48, 0, 6, 6, 6, 0, 2, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 28, 28, 28, 0, 80, 80, 80, 0, 177, 177, 177, 0, 255, 255, 255, 0, 229, 229, 229, 0, 253, 254, 254, 0, 244, 244, 244, 0, 132, 132, 132, 0, 100, 100, 100, 0, 71, 71, 71, 0, 43, 43, 43, 0, 31, 31, 31, 0, 27, 28, 28, 0, 2, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 64, 63, 64, 0, 148, 148, 148, 0, 161, 161, 162, 0, 141, 141, 141, 0, 209, 209, 209, 0, 77, 77, 77, 0, 139, 139, 139, 0, 107, 107, 108, 0, 32, 32, 32, 0, 22, 22, 22, 0, 14, 14, 14, 0, 6, 6, 6, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 39, 39, 39, 0, 53, 53, 53, 0, 0, 0, 0, 0, 154, 154, 153, 0, 152, 151, 150, 0, 124, 125, 125, 0, 94, 94, 94, 0, 71, 71, 71, 0, 53, 54, 53, 0, 36, 37, 36, 0, 28, 28, 28, 0, 50, 48, 48, 0, 10, 10, 10, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 11, 11, 11, 0, 11, 11, 11, 0, 17, 17, 17, 0, 20, 20, 20, 0, 23, 23, 23, 0, 20, 20, 20, 0, 36, 37, 36, 0, 11, 11, 11, 0, 7, 8, 7, 0, 7, 7, 7, 0, 4, 4, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 6, 6, 0, 100, 99, 102, 0, 83, 84, 83, 0, 114, 114, 113, 0, 140, 139, 140, 0, 153, 153, 153, 0, 145, 145, 144, 0, 125, 125, 126, 0, 107, 107, 106, 0, 82, 82, 82, 0, 110, 110, 110, 0, 25, 25, 25, 0, 15, 16, 16, 0, 10, 10, 10, 0, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 19, 19, 19, 0, 66, 66, 66, 0, 160, 160, 160, 0, 255, 255, 255, 0, 242, 242, 242, 0, 254, 254, 254, 0, 251, 251, 251, 0, 159, 160, 159, 0, 132, 133, 132, 0, 103, 103, 102, 0, 73, 73, 72, 0, 57, 57, 57, 0, 75, 76, 75, 0, 13, 13, 13, 0, 6, 6, 6, 0, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 51, 51, 51, 0, 128, 129, 129, 0, 140, 140, 141, 0, 125, 125, 125, 0, 200, 200, 200, 0, 71, 71, 71, 0, 134, 133, 132, 0, 108, 107, 107, 0, 34, 34, 34, 0, 27, 27, 27, 0, 19, 19, 19, 0, 11, 11, 11, 0, 0, 0, 0, 0, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 30, 30, 30, 0, 40, 40, 40, 0, 0, 0, 0, 0, 133, 133, 133, 0, 132, 131, 132, 0, 110, 111, 111, 0, 86, 86, 86, 0, 66, 66, 65, 0, 52, 51, 51, 0, 37, 37, 37, 0, 32, 31, 32, 0, 60, 60, 60, 0, 16, 16, 16, 0, 0, 0, 0, 0, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 6, 6, 0, 9, 9, 9, 0, 15, 15, 15, 0, 22, 21, 22, 0, 29, 29, 29, 0, 28, 28, 28, 0, 63, 62, 63, 0, 22, 22, 22, 0, 20, 20, 20, 0, 20, 20, 20, 0, 18, 18, 18, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 3, 3, 0, 83, 81, 81, 0, 74, 74, 75, 0, 106, 106, 106, 0, 140, 140, 140, 0, 162, 162, 162, 0, 166, 166, 166, 0, 156, 156, 156, 0, 141, 142, 142, 0, 118, 118, 118, 0, 168, 170, 170, 0, 54, 54, 54, 0, 39, 39, 39, 0, 30, 31, 31, 0, 16, 16, 16, 0, 7, 7, 7, 0, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 13, 13, 13, 0, 53, 53, 54, 0, 142, 142, 142, 0, 253, 253, 254, 0, 232, 232, 232, 0, 254, 255, 254, 0, 253, 254, 254, 0, 177, 176, 177, 0, 155, 156, 155, 0, 130, 130, 129, 0, 98, 99, 98, 0, 83, 83, 82, 0, 123, 123, 122, 0, 30, 30, 30, 0, 17, 17, 17, 0, 12, 12, 12, 0, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 39, 39, 39, 0, 112, 112, 112, 0, 122, 122, 122, 0, 108, 108, 109, 0, 185, 184, 185, 0, 62, 62, 62, 0, 121, 120, 120, 0, 99, 96, 98, 0, 33, 32, 32, 0, 27, 27, 27, 0, 22, 22, 22, 0, 15, 15, 15, 0, 0, 0, 0, 0, 8, 8, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 24, 24, 24, 0, 31, 30, 30, 0, 0, 0, 0, 0, 116, 117, 116, 0, 115, 114, 114, 0, 96, 97, 96, 0, 76, 75, 76, 0, 57, 57, 57, 0, 46, 46, 46, 0, 34, 33, 34, 0, 31, 31, 31, 0, 60, 61, 61, 0, 17, 18, 18, 0, 0, 0, 0, 0, 9, 9, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 5, 5, 0, 11, 12, 11, 0, 19, 19, 19, 0, 31, 31, 31, 0, 34, 34, 34, 0, 83, 84, 83, 0, 35, 34, 35, 0, 36, 36, 36, 0, 38, 38, 38, 0, 34, 35, 35, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 47, 47, 47, 0, 56, 56, 56, 0, 89, 88, 88, 0, 127, 128, 127, 0, 151, 151, 151, 0, 178, 178, 178, 0, 183, 183, 183, 0, 178, 178, 178, 0, 159, 159, 159, 0, 215, 214, 215, 0, 90, 90, 90, 0, 71, 72, 71, 0, 59, 59, 59, 0, 38, 37, 37, 0, 21, 22, 22, 0, 13, 12, 13, 0, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 3, 3, 0, 30, 30, 30, 0, 107, 108, 107, 0, 246, 246, 246, 0, 200, 200, 200, 0, 253, 253, 253, 0, 203, 203, 203, 0, 183, 182, 182, 0, 172, 172, 172, 0, 152, 152, 152, 0, 122, 122, 122, 0, 107, 107, 108, 0, 165, 165, 165, 0, 49, 48, 49, 0, 32, 32, 32, 0, 25, 25, 25, 0, 13, 13, 13, 0, 4, 4, 4, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 15, 16, 15, 0, 71, 71, 71, 0, 86, 86, 86, 0, 77, 77, 77, 0, 152, 152, 152, 0, 45, 45, 45, 0, 93, 93, 93, 0, 79, 79, 79, 0, 26, 25, 26, 0, 24, 23, 24, 0, 21, 21, 21, 0, 16, 16, 16, 0, 0, 0, 0, 0, 11, 10, 11, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 8, 8, 0, 11, 11, 11, 0, 0, 0, 0, 0, 78, 78, 78, 0, 81, 81, 80, 0, 69, 69, 69, 0, 55, 55, 55, 0, 42, 43, 42, 0, 35, 34, 35, 0, 25, 25, 26, 0, 26, 25, 26, 0, 23, 23, 23, 0, 18, 18, 17, 0, 0, 0, 0, 0, 12, 11, 11, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 2, 2, 0, 7, 7, 7, 0, 15, 15, 15, 0, 29, 29, 29, 0, 35, 35, 35, 0, 93, 93, 93, 0, 44, 43, 44, 0, 48, 48, 48, 0, 53, 52, 53, 0, 51, 50, 51, 0, 2, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 19, 19, 19, 0, 36, 36, 36, 0, 65, 65, 65, 0, 108, 108, 108, 0, 151, 151, 151, 0, 173, 173, 173, 0, 195, 195, 194, 0, 201, 201, 201, 0, 189, 188, 189, 0, 237, 237, 239, 0, 121, 121, 122, 0, 100, 100, 100, 0, 85, 86, 85, 0, 58, 58, 58, 0, 37, 37, 37, 0, 24, 24, 24, 0, 13, 13, 13, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 10, 10, 10, 0, 74, 73, 73, 0, 226, 226, 227, 0, 162, 162, 162, 0, 246, 246, 247, 0, 184, 184, 184, 0, 172, 172, 172, 0, 173, 172, 172, 0, 160, 160, 160, 0, 135, 134, 134, 0, 123, 123, 123, 0, 189, 189, 189, 0, 64, 64, 64, 0, 44, 44, 44, 0, 35, 35, 35, 0, 21, 21, 21, 0, 9, 9, 9, 0, 4, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 4, 4, 0, 31, 31, 31, 0, 44, 44, 44, 0, 47, 47, 47, 0, 108, 107, 108, 0, 27, 28, 28, 0, 63, 63, 61, 0, 15, 15, 15, 0, 18, 18, 18, 0, 17, 17, 18, 0, 17, 17, 17, 0, 14, 14, 14, 0, 0, 0, 0, 0, 11, 11, 11, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 35, 36, 35, 0, 44, 44, 44, 0, 42, 43, 43, 0, 34, 34, 34, 0, 26, 26, 26, 0, 22, 22, 21, 0, 16, 16, 17, 0, 18, 18, 19, 0, 18, 18, 18, 0, 14, 14, 14, 0, 0, 0, 0, 0, 11, 11, 11, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 2, 2, 0, 8, 8, 7, 0, 22, 22, 21, 0, 30, 30, 30, 0, 40, 40, 40, 0, 51, 51, 51, 0, 64, 64, 64, 0, 73, 72, 73, 0, 74, 74, 73, 0, 4, 4, 4, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 16, 16, 16, 0, 38, 38, 38, 0, 75, 76, 76, 0, 123, 123, 123, 0, 150, 150, 150, 0, 185, 185, 185, 0, 210, 210, 211, 0, 215, 214, 214, 0, 251, 251, 251, 0, 168, 168, 169, 0, 145, 144, 145, 0, 128, 129, 127, 0, 96, 95, 96, 0, 68, 68, 68, 0, 49, 49, 49, 0, 32, 32, 32, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 33, 32, 33, 0, 184, 182, 182, 0, 116, 116, 116, 0, 222, 222, 222, 0, 145, 145, 146, 0, 142, 142, 141, 0, 153, 153, 153, 0, 152, 152, 152, 0, 136, 136, 136, 0, 131, 131, 131, 0, 208, 208, 207, 0, 81, 81, 81, 0, 59, 59, 59, 0, 49, 49, 50, 0, 33, 33, 33, 0, 18, 18, 18, 0, 10, 10, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 9, 9, 9, 0, 14, 14, 14, 0, 16, 16, 16, 0, 14, 14, 14, 0, 10, 10, 10, 0, 6, 6, 6, 0, 4, 5, 4, 0, 7, 7, 7, 0, 8, 9, 8, 0, 10, 10, 10, 0, 10, 10, 10, 0, 0, 0, 0, 0, 10, 10, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 11, 11, 11, 0, 14, 14, 14, 0, 16, 16, 16, 0, 14, 14, 14, 0, 9, 9, 9, 0, 8, 8, 8, 0, 6, 6, 6, 0, 8, 9, 8, 0, 10, 10, 10, 0, 8, 8, 8, 0, 0, 0, 0, 0, 9, 9, 9, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 2, 2, 0, 13, 13, 12, 0, 21, 21, 21, 0, 34, 34, 33, 0, 51, 51, 51, 0, 71, 71, 72, 0, 86, 86, 86, 0, 90, 90, 89, 0, 4, 4, 4, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 3, 3, 0, 16, 16, 16, 0, 46, 46, 46, 0, 89, 89, 89, 0, 117, 117, 117, 0, 157, 157, 157, 0, 191, 191, 191, 0, 211, 212, 212, 0, 255, 254, 255, 0, 209, 209, 209, 0, 185, 185, 185, 0, 168, 168, 168, 0, 132, 132, 132, 0, 99, 99, 99, 0, 75, 76, 75, 0, 53, 53, 53, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 10, 10, 10, 0, 107, 107, 107, 0, 70, 70, 70, 0, 180, 180, 180, 0, 106, 105, 105, 0, 105, 105, 105, 0, 122, 122, 122, 0, 129, 129, 129, 0, 122, 122, 122, 0, 123, 123, 124, 0, 212, 211, 211, 0, 89, 88, 89, 0, 66, 66, 67, 0, 58, 58, 58, 0, 41, 42, 42, 0, 26, 26, 25, 0, 16, 15, 15, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 3, 3, 2, 0, 3, 3, 3, 0, 2, 2, 2, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 2, 2, 2, 0, 4, 4, 4, 0, 4, 4, 4, 0, 0, 0, 0, 0, 6, 6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 2, 2, 0, 3, 3, 3, 0, 2, 2, 2, 0, 2, 2, 2, 0, 1, 1, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 2, 2, 2, 0, 3, 3, 3, 0, 3, 3, 3, 0, 0, 0, 0, 0, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 5, 5, 0, 11, 11, 11, 0, 22, 22, 22, 0, 43, 43, 44, 0, 70, 70, 70, 0, 89, 89, 89, 0, 99, 99, 99, 0, 3, 3, 3, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 3, 3, 0, 21, 20, 21, 0, 56, 56, 57, 0, 82, 82, 82, 0, 119, 119, 119, 0, 156, 156, 156, 0, 183, 183, 183, 0, 255, 255, 255, 0, 243, 243, 243, 0, 221, 222, 221, 0, 205, 206, 205, 0, 174, 174, 174, 0, 139, 140, 139, 0, 110, 110, 110, 0, 84, 84, 84, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 2, 2, 0, 44, 44, 44, 0, 32, 32, 32, 0, 49, 49, 49, 0, 68, 68, 68, 0, 70, 70, 70, 0, 87, 87, 87, 0, 97, 97, 97, 0, 95, 96, 95, 0, 102, 102, 102, 0, 203, 203, 203, 0, 85, 85, 85, 0, 66, 66, 66, 0, 60, 59, 59, 0, 46, 45, 46, 0, 32, 32, 32, 0, 20, 20, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 3, 3, 0, 10, 10, 10, 0, 30, 30, 30, 0, 59, 59, 59, 0, 81, 81, 81, 0, 94, 95, 94, 0, 2, 2, 2, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 4, 4, 0, 23, 23, 23, 0, 45, 45, 45, 0, 80, 79, 79, 0, 113, 113, 113, 0, 143, 143, 143, 0, 252, 252, 253, 0, 232, 232, 232, 0, 229, 230, 230, 0, 221, 221, 221, 0, 199, 199, 200, 0, 168, 167, 168, 0, 138, 138, 137, 0, 109, 109, 110, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 9, 9, 9, 0, 9, 9, 9, 0, 16, 17, 17, 0, 27, 27, 27, 0, 32, 32, 32, 0, 51, 51, 51, 0, 62, 62, 62, 0, 64, 64, 64, 0, 72, 72, 73, 0, 179, 177, 179, 0, 70, 70, 70, 0, 55, 55, 55, 0, 51, 51, 51, 0, 42, 42, 42, 0, 32, 32, 32, 0, 20, 21, 21, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 2, 2, 0, 15, 15, 15, 0, 41, 41, 41, 0, 62, 62, 63, 0, 78, 78, 78, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 5, 5, 0, 15, 15, 15, 0, 39, 39, 39, 0, 73, 72, 72, 0, 100, 100, 100, 0, 239, 240, 239, 0, 192, 192, 192, 0, 202, 202, 201, 0, 203, 203, 203, 0, 201, 200, 201, 0, 180, 180, 180, 0, 151, 151, 150, 0, 126, 126, 126, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 3, 3, 3, 0, 7, 7, 7, 0, 9, 9, 9, 0, 19, 18, 18, 0, 29, 29, 29, 0, 34, 34, 34, 0, 42, 42, 42, 0, 136, 135, 136, 0, 48, 48, 48, 0, 38, 39, 38, 0, 36, 37, 36, 0, 32, 32, 32, 0, 25, 25, 25, 0, 16, 16, 16, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 4, 4, 0, 21, 21, 21, 0, 38, 38, 38, 0, 52, 52, 52, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 2, 2, 0, 12, 12, 12, 0, 29, 29, 29, 0, 52, 52, 53, 0, 205, 205, 205, 0, 142, 142, 142, 0, 156, 156, 156, 0, 163, 163, 163, 0, 173, 172, 172, 0, 167, 167, 166, 0, 143, 144, 143, 0, 126, 126, 126, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 0, 3, 3, 3, 0, 7, 7, 7, 0, 10, 9, 10, 0, 16, 16, 16, 0, 78, 78, 78, 0, 25, 25, 25, 0, 19, 19, 19, 0, 19, 19, 19, 0, 17, 17, 17, 0, 15, 15, 15, 0, 9, 9, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 7, 7, 7, 0, 18, 18, 18, 0, 29, 29, 29, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 2, 2, 0, 8, 8, 8, 0, 19, 19, 19, 0, 51, 51, 51, 0, 98, 98, 98, 0, 111, 112, 111, 0, 119, 119, 119, 0, 134, 134, 134, 0, 136, 136, 136, 0, 120, 121, 121, 0, 109, 110, 110, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 0, 2, 2, 2, 0, 27, 27, 27, 0, 8, 8, 8, 0, 6, 6, 6, 0, 6, 6, 6, 0, 6, 6, 6, 0, 5, 5, 5, 0, 2, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 3, 3, 0, 11, 11, 11, 0, 19, 19, 19, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 4, 4, 4, 0, 11, 11, 11, 0, 34, 34, 34, 0, 77, 77, 77, 0, 92, 92, 92, 0, 99, 99, 99, 0, 115, 115, 115, 0, 119, 118, 119, 0, 106, 106, 106, 0, 98, 98, 98, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 11, 11, 11, 0, 4, 4, 4, 0, 2, 2, 2, 0, 2, 2, 2, 0, 2, 3, 2, 0, 3, 3, 3, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 2, 2, 0, 11, 11, 11, 0, 32, 33, 32, 0, 46, 46, 46, 0, 55, 55, 55, 0, 75, 75, 75, 0, 82, 82, 82, 0, 72, 72, 73, 0, 69, 69, 69, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 4, 4, 0, 16, 16, 16, 0, 23, 23, 23, 0, 29, 30, 30, 0, 46, 46, 46, 0, 57, 56, 57, 0, 50, 50, 50, 0, 48, 48, 48, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 5, 5, 0, 8, 8, 8, 0, 10, 11, 10, 0, 19, 19, 19, 0, 26, 26, 26, 0, 24, 24, 24, 0, 25, 25, 26, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 2, 2, 2, 0, 3, 3, 3, 0, 7, 7, 7, 0, 10, 10, 10, 0, 8, 8, 8, 0, 9, 9, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 2, 2, 2, 0, 3, 3, 3, 0, 2, 2, 2, 0, 2, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 2, 3, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 7, 7, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 8, 8, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 16, 17, 17, 0, 0, 0, 0, 0, 0, 0, 0, 0, 20, 20, 20, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 21, 21, 22, 0, 0, 0, 0, 0, 0, 0, 0, 0, 25, 26, 25, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 24, 24, 24, 0, 0, 0, 0, 0, 0, 0, 0, 0, 29, 30, 30, 0, 205, 204, 204, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 29, 29, 29, 0, 0, 0, 0, 0, 0, 0, 0, 0, 35, 35, 35, 0 };

        #endregion Embedded Effects

        void ShowEffect47()
        {
            const string baseLayer = "Embedded/Arc_Keyboard.chroma";
            // close the blank animation if it's already loaded, discarding any changes
            ChromaAnimationAPI.CloseAnimationName(baseLayer);
            // open the bytes from memory and name it
            ChromaAnimationAPI.OpenAnimationFromMemory(EMBED_ARC1_KEYBOARD, baseLayer);
            // set animation playback to 30 FPS
            ChromaAnimationAPI.OverrideFrameDurationName(baseLayer, 0.033f);
            // play the animation on the dynamic canvas
            ChromaAnimationAPI.PlayAnimationName(baseLayer, true);
        }
    }    
}
