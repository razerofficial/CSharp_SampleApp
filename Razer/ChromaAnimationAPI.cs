using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace ChromaSDK
{
    public class Keyboard
    {
        //! Definitions of keys.
        public enum RZKEY
        {
            RZKEY_ESC = 0x0001,                 /*!< Esc (VK_ESCAPE) */
            RZKEY_F1 = 0x0003,                  /*!< F1 (VK_F1) */
            RZKEY_F2 = 0x0004,                  /*!< F2 (VK_F2) */
            RZKEY_F3 = 0x0005,                  /*!< F3 (VK_F3) */
            RZKEY_F4 = 0x0006,                  /*!< F4 (VK_F4) */
            RZKEY_F5 = 0x0007,                  /*!< F5 (VK_F5) */
            RZKEY_F6 = 0x0008,                  /*!< F6 (VK_F6) */
            RZKEY_F7 = 0x0009,                  /*!< F7 (VK_F7) */
            RZKEY_F8 = 0x000A,                  /*!< F8 (VK_F8) */
            RZKEY_F9 = 0x000B,                  /*!< F9 (VK_F9) */
            RZKEY_F10 = 0x000C,                 /*!< F10 (VK_F10) */
            RZKEY_F11 = 0x000D,                 /*!< F11 (VK_F11) */
            RZKEY_F12 = 0x000E,                 /*!< F12 (VK_F12) */
            RZKEY_1 = 0x0102,                   /*!< 1 (VK_1) */
            RZKEY_2 = 0x0103,                   /*!< 2 (VK_2) */
            RZKEY_3 = 0x0104,                   /*!< 3 (VK_3) */
            RZKEY_4 = 0x0105,                   /*!< 4 (VK_4) */
            RZKEY_5 = 0x0106,                   /*!< 5 (VK_5) */
            RZKEY_6 = 0x0107,                   /*!< 6 (VK_6) */
            RZKEY_7 = 0x0108,                   /*!< 7 (VK_7) */
            RZKEY_8 = 0x0109,                   /*!< 8 (VK_8) */
            RZKEY_9 = 0x010A,                   /*!< 9 (VK_9) */
            RZKEY_0 = 0x010B,                   /*!< 0 (VK_0) */
            RZKEY_A = 0x0302,                   /*!< A (VK_A) */
            RZKEY_B = 0x0407,                   /*!< B (VK_B) */
            RZKEY_C = 0x0405,                   /*!< C (VK_C) */
            RZKEY_D = 0x0304,                   /*!< D (VK_D) */
            RZKEY_E = 0x0204,                   /*!< E (VK_E) */
            RZKEY_F = 0x0305,                   /*!< F (VK_F) */
            RZKEY_G = 0x0306,                   /*!< G (VK_G) */
            RZKEY_H = 0x0307,                   /*!< H (VK_H) */
            RZKEY_I = 0x0209,                   /*!< I (VK_I) */
            RZKEY_J = 0x0308,                   /*!< J (VK_J) */
            RZKEY_K = 0x0309,                   /*!< K (VK_K) */
            RZKEY_L = 0x030A,                   /*!< L (VK_L) */
            RZKEY_M = 0x0409,                   /*!< M (VK_M) */
            RZKEY_N = 0x0408,                   /*!< N (VK_N) */
            RZKEY_O = 0x020A,                   /*!< O (VK_O) */
            RZKEY_P = 0x020B,                   /*!< P (VK_P) */
            RZKEY_Q = 0x0202,                   /*!< Q (VK_Q) */
            RZKEY_R = 0x0205,                   /*!< R (VK_R) */
            RZKEY_S = 0x0303,                   /*!< S (VK_S) */
            RZKEY_T = 0x0206,                   /*!< T (VK_T) */
            RZKEY_U = 0x0208,                   /*!< U (VK_U) */
            RZKEY_V = 0x0406,                   /*!< V (VK_V) */
            RZKEY_W = 0x0203,                   /*!< W (VK_W) */
            RZKEY_X = 0x0404,                   /*!< X (VK_X) */
            RZKEY_Y = 0x0207,                   /*!< Y (VK_Y) */
            RZKEY_Z = 0x0403,                   /*!< Z (VK_Z) */
            RZKEY_NUMLOCK = 0x0112,             /*!< Numlock (VK_NUMLOCK) */
            RZKEY_NUMPAD0 = 0x0513,             /*!< Numpad 0 (VK_NUMPAD0) */
            RZKEY_NUMPAD1 = 0x0412,             /*!< Numpad 1 (VK_NUMPAD1) */
            RZKEY_NUMPAD2 = 0x0413,             /*!< Numpad 2 (VK_NUMPAD2) */
            RZKEY_NUMPAD3 = 0x0414,             /*!< Numpad 3 (VK_NUMPAD3) */
            RZKEY_NUMPAD4 = 0x0312,             /*!< Numpad 4 (VK_NUMPAD4) */
            RZKEY_NUMPAD5 = 0x0313,             /*!< Numpad 5 (VK_NUMPAD5) */
            RZKEY_NUMPAD6 = 0x0314,             /*!< Numpad 6 (VK_NUMPAD6) */
            RZKEY_NUMPAD7 = 0x0212,             /*!< Numpad 7 (VK_NUMPAD7) */
            RZKEY_NUMPAD8 = 0x0213,             /*!< Numpad 8 (VK_NUMPAD8) */
            RZKEY_NUMPAD9 = 0x0214,             /*!< Numpad 9 (VK_ NUMPAD9*/
            RZKEY_NUMPAD_DIVIDE = 0x0113,       /*!< Divide (VK_DIVIDE) */
            RZKEY_NUMPAD_MULTIPLY = 0x0114,     /*!< Multiply (VK_MULTIPLY) */
            RZKEY_NUMPAD_SUBTRACT = 0x0115,     /*!< Subtract (VK_SUBTRACT) */
            RZKEY_NUMPAD_ADD = 0x0215,          /*!< Add (VK_ADD) */
            RZKEY_NUMPAD_ENTER = 0x0415,        /*!< Enter (VK_RETURN - Extended) */
            RZKEY_NUMPAD_DECIMAL = 0x0514,      /*!< Decimal (VK_DECIMAL) */
            RZKEY_PRINTSCREEN = 0x000F,         /*!< Print Screen (VK_PRINT) */
            RZKEY_SCROLL = 0x0010,              /*!< Scroll Lock (VK_SCROLL) */
            RZKEY_PAUSE = 0x0011,               /*!< Pause (VK_PAUSE) */
            RZKEY_INSERT = 0x010F,              /*!< Insert (VK_INSERT) */
            RZKEY_HOME = 0x0110,                /*!< Home (VK_HOME) */
            RZKEY_PAGEUP = 0x0111,              /*!< Page Up (VK_PRIOR) */
            RZKEY_DELETE = 0x020f,              /*!< Delete (VK_DELETE) */
            RZKEY_END = 0x0210,                 /*!< End (VK_END) */
            RZKEY_PAGEDOWN = 0x0211,            /*!< Page Down (VK_NEXT) */
            RZKEY_UP = 0x0410,                  /*!< Up (VK_UP) */
            RZKEY_LEFT = 0x050F,                /*!< Left (VK_LEFT) */
            RZKEY_DOWN = 0x0510,                /*!< Down (VK_DOWN) */
            RZKEY_RIGHT = 0x0511,               /*!< Right (VK_RIGHT) */
            RZKEY_TAB = 0x0201,                 /*!< Tab (VK_TAB) */
            RZKEY_CAPSLOCK = 0x0301,            /*!< Caps Lock(VK_CAPITAL) */
            RZKEY_BACKSPACE = 0x010E,           /*!< Backspace (VK_BACK) */
            RZKEY_ENTER = 0x030E,               /*!< Enter (VK_RETURN) */
            RZKEY_LCTRL = 0x0501,               /*!< Left Control(VK_LCONTROL) */
            RZKEY_LWIN = 0x0502,                /*!< Left Window (VK_LWIN) */
            RZKEY_LALT = 0x0503,                /*!< Left Alt (VK_LMENU) */
            RZKEY_SPACE = 0x0507,               /*!< Spacebar (VK_SPACE) */
            RZKEY_RALT = 0x050B,                /*!< Right Alt (VK_RMENU) */
            RZKEY_FN = 0x050C,                  /*!< Function key. */
            RZKEY_RMENU = 0x050D,               /*!< Right Menu (VK_APPS) */
            RZKEY_RCTRL = 0x050E,               /*!< Right Control (VK_RCONTROL) */
            RZKEY_LSHIFT = 0x0401,              /*!< Left Shift (VK_LSHIFT) */
            RZKEY_RSHIFT = 0x040E,              /*!< Right Shift (VK_RSHIFT) */
            RZKEY_MACRO1 = 0x0100,              /*!< Macro Key 1 */
            RZKEY_MACRO2 = 0x0200,              /*!< Macro Key 2 */
            RZKEY_MACRO3 = 0x0300,              /*!< Macro Key 3 */
            RZKEY_MACRO4 = 0x0400,              /*!< Macro Key 4 */
            RZKEY_MACRO5 = 0x0500,              /*!< Macro Key 5 */
            RZKEY_OEM_1 = 0x0101,               /*!< ~ (tilde/半角/全角) (VK_OEM_3) */
            RZKEY_OEM_2 = 0x010C,               /*!< -- (minus) (VK_OEM_MINUS) */
            RZKEY_OEM_3 = 0x010D,               /*!< = (equal) (VK_OEM_PLUS) */
            RZKEY_OEM_4 = 0x020C,               /*!< [ (left sqaure bracket) (VK_OEM_4) */
            RZKEY_OEM_5 = 0x020D,               /*!< ] (right square bracket) (VK_OEM_6) */
            RZKEY_OEM_6 = 0x020E,               /*!< \ (backslash) (VK_OEM_5) */
            RZKEY_OEM_7 = 0x030B,               /*!< ; (semi-colon) (VK_OEM_1) */
            RZKEY_OEM_8 = 0x030C,               /*!< ' (apostrophe) (VK_OEM_7) */
            RZKEY_OEM_9 = 0x040A,               /*!< , (comma) (VK_OEM_COMMA) */
            RZKEY_OEM_10 = 0x040B,              /*!< . (period) (VK_OEM_PERIOD) */
            RZKEY_OEM_11 = 0x040C,              /*!< / (forward slash) (VK_OEM_2) */
            RZKEY_EUR_1 = 0x030D,               /*!< "#" (VK_OEM_5) */
            RZKEY_EUR_2 = 0x0402,               /*!< \ (VK_OEM_102) */
            RZKEY_JPN_1 = 0x0015,               /*!< ¥ (0xFF) */
            RZKEY_JPN_2 = 0x040D,               /*!< \ (0xC1) */
            RZKEY_JPN_3 = 0x0504,               /*!< 無変換 (VK_OEM_PA1) */
            RZKEY_JPN_4 = 0x0509,               /*!< 変換 (0xFF) */
            RZKEY_JPN_5 = 0x050A,               /*!< ひらがな/カタカナ (0xFF) */
            RZKEY_KOR_1 = 0x0015,               /*!< | (0xFF) */
            RZKEY_KOR_2 = 0x030D,               /*!< (VK_OEM_5) */
            RZKEY_KOR_3 = 0x0402,               /*!< (VK_OEM_102) */
            RZKEY_KOR_4 = 0x040D,               /*!< (0xC1) */
            RZKEY_KOR_5 = 0x0504,               /*!< (VK_OEM_PA1) */
            RZKEY_KOR_6 = 0x0509,               /*!< 한/영 (0xFF) */
            RZKEY_KOR_7 = 0x050A,               /*!< (0xFF) */
            RZKEY_INVALID = 0xFFFF              /*!< Invalid keys. */
        }

        //! Definition of LEDs.
        public enum RZLED
        {
            RZLED_LOGO = 0x0014                 /*!< Razer logo */
        };
    }

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct APPINFOTYPE
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string Title; //TCHAR Title[256];

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1024)]
		public string Description; //TCHAR Description[1024];

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string Author_Name; //TCHAR Name[256];

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string Author_Contact; //TCHAR Contact[256];

		public UInt32 SupportedDevice; //DWORD SupportedDevice;

		public UInt32 Category; //DWORD Category;
	}

    [StructLayout(LayoutKind.Sequential)]
    public struct FChromaSDKGuid
    {
        Guid Data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DEVICE_INFO_TYPE
    {
        int DeviceType;
        uint Connected;
    }

    public enum EFFECT_TYPE
    {
        CHROMA_NONE = 0,            //!< No effect.
        CHROMA_WAVE,                //!< Wave effect (This effect type has deprecated and should not be used).
        CHROMA_SPECTRUMCYCLING,     //!< Spectrum cycling effect (This effect type has deprecated and should not be used).
        CHROMA_BREATHING,           //!< Breathing effect (This effect type has deprecated and should not be used).
        CHROMA_BLINKING,            //!< Blinking effect (This effect type has deprecated and should not be used).
        CHROMA_REACTIVE,            //!< Reactive effect (This effect type has deprecated and should not be used).
        CHROMA_STATIC,              //!< Static effect.
        CHROMA_CUSTOM,              //!< Custom effect. For mice, please see Mouse::CHROMA_CUSTOM2.
        CHROMA_RESERVED,            //!< Reserved
        CHROMA_INVALID              //!< Invalid effect.
    }

    namespace Stream
    {
        public enum StreamStatusType
        {
            READY = 0, // ready for commands
            AUTHORIZING = 1, // the session is being authorized
            BROADCASTING = 2, // the session is being broadcast
            WATCHING = 3, // A stream is being watched
            NOT_AUTHORIZED = 4, // The session is not authorized
            BROADCAST_DUPLICATE = 5, // The session has duplicate broadcasters
            SERVICE_OFFLINE = 6, // The service is offline
        }

        public class Default
        {
            const uint LENGTH_SHORTCODE = 6;
            const uint LENGTH_STREAM_ID = 48;
            const uint LENGTH_STREAM_KEY = 48;
            const uint LENGTH_STREAM_FOCUS = 48;

            static string GetDefaultString(uint length)
            {
                string result = string.Empty;
                for (uint i = 0; i < length; ++i)
                {
                    result += " ";
                }
                return result;
            }

            public readonly static string Shortcode = GetDefaultString(LENGTH_SHORTCODE);
            public readonly static string StreamId = GetDefaultString(LENGTH_STREAM_ID);
            public readonly static string StreamKey = GetDefaultString(LENGTH_STREAM_KEY);
            public readonly static string StreamFocus = GetDefaultString(LENGTH_STREAM_FOCUS);
        }
    }

    public class ChromaAnimationAPI
    {

#if X64
        const string DLL_NAME = "CChromaEditorLibrary64";
#else
        const string DLL_NAME = "CChromaEditorLibrary";
#endif

#region Data Structures

        public enum DeviceType
        {
            Invalid = -1,
            DE_1D = 0,
            DE_2D = 1,
            MAX = 2,
        }

        public enum Device
        {
            Invalid = -1,
            ChromaLink = 0,
            Headset = 1,
            Keyboard = 2,
            Keypad = 3,
            Mouse = 4,
            Mousepad = 5,
            MAX = 6,
        }

        public enum Device1D
        {
            Invalid = -1,
            ChromaLink = 0,
            Headset = 1,
            Mousepad = 2,
            MAX = 3,
        }

        public enum Device2D
        {
            Invalid = -1,
            Keyboard = 0,
            Keypad = 1,
            Mouse = 2,
            MAX = 3,
        }

		public class FChromaSDKDeviceFrameIndex
		{
			// Index corresponds to EChromaSDKDeviceEnum;
			public int[] _mFrameIndex = new int[6];

			public FChromaSDKDeviceFrameIndex()
			{
				_mFrameIndex[(int)Device.ChromaLink] = 0;
				_mFrameIndex[(int)Device.Headset] = 0;
				_mFrameIndex[(int)Device.Keyboard] = 0;
				_mFrameIndex[(int)Device.Keypad] = 0;
				_mFrameIndex[(int)Device.Mouse] = 0;
				_mFrameIndex[(int)Device.Mousepad] = 0;
			}
		}

		public enum EChromaSDKSceneBlend
		{
			SB_None,
			SB_Invert,
			SB_Threshold,
			SB_Lerp,
		};

		public enum EChromaSDKSceneMode
		{
			SM_Replace,
			SM_Max,
			SM_Min,
			SM_Average,
			SM_Multiply,
			SM_Add,
			SM_Subtract,
		};

		public class FChromaSDKSceneEffect
		{
			public string _mAnimation = "";
			public bool _mState = false;
			public int _mPrimaryColor = 0;
			public int _mSecondaryColor = 0;
			public int _mSpeed = 1;
			public EChromaSDKSceneBlend _mBlend = EChromaSDKSceneBlend.SB_None;
			public EChromaSDKSceneMode _mMode = EChromaSDKSceneMode.SM_Replace;

			public FChromaSDKDeviceFrameIndex _mFrameIndex = new FChromaSDKDeviceFrameIndex();
		}


		public class FChromaSDKScene
		{
			public List<FChromaSDKSceneEffect> _mEffects = new List<FChromaSDKSceneEffect>();
		}


#endregion

#region Helpers (handle path conversions)

    /// <summary>
    /// Helper to convert path string to IntPtr
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    private static IntPtr GetPathIntPtr(string path)
    {
        if (string.IsNullOrEmpty(path))
        {
            return IntPtr.Zero;
        }
        FileInfo fi = new FileInfo(path);
        byte[] array = ASCIIEncoding.ASCII.GetBytes(fi.FullName + "\0");
        IntPtr lpData = Marshal.AllocHGlobal(array.Length);
        Marshal.Copy(array, 0, lpData, array.Length);
        return lpData;
    }

    /// <summary>
    /// Helper to Ascii path string to IntPtr
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    private static IntPtr GetAsciiIntPtr(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return IntPtr.Zero;
        }
        byte[] array = ASCIIEncoding.ASCII.GetBytes(str + "\0");
        IntPtr lpData = Marshal.AllocHGlobal(array.Length);
        Marshal.Copy(array, 0, lpData, array.Length);
        return lpData;
    }

    /// <summary>
    /// Helper to Unicode path string to IntPtr
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    private static IntPtr GetUnicodeIntPtr(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return IntPtr.Zero;
        }
        byte[] array = UnicodeEncoding.Unicode.GetBytes(str + "\0");
        IntPtr lpData = Marshal.AllocHGlobal(array.Length);
        Marshal.Copy(array, 0, lpData, array.Length);
        return lpData;
    }

    /// <summary>
    /// Helper to recycle the IntPtr
    /// </summary>
    /// <param name="lpData"></param>
    private static void FreeIntPtr(IntPtr lpData)
    {
        if (lpData != IntPtr.Zero)
        {
            Marshal.FreeHGlobal(lpData);
        }
    }

    public static int UninitAPI()
    {
        UnloadLibrarySDK();
        UnloadLibraryStreamingPlugin();

        return 0;
    }

#endregion


		#region Public API Methods
		/// <summary>
		/// Return the sum of colors
		/// </summary>
		public static int AddColor(int color1, int color2)
		{
			int result = PluginAddColor(color1, color2);
			return result;
		}
		/// <summary>
		/// Adds a frame to the `Chroma` animation and sets the `duration` (in seconds). 
		/// The `color` is expected to be an array of the dimensions for the `deviceType/device`. 
		/// The `length` parameter is the size of the `color` array. For `EChromaSDKDevice1DEnum` 
		/// the array size should be `MAX LEDS`. For `EChromaSDKDevice2DEnum` the array 
		/// size should be `MAX ROW` times `MAX COLUMN`. Returns the animation id upon 
		/// success. Returns negative one upon failure.
		/// </summary>
		public static int AddFrame(int animationId, float duration, int[] colors, int length)
		{
			int result = PluginAddFrame(animationId, duration, colors, length);
			return result;
		}
		/// <summary>
		/// Add source color to target where color is not black for frame id, reference 
		/// source and target by id.
		/// </summary>
		public static void AddNonZeroAllKeys(int sourceAnimationId, int targetAnimationId, int frameId)
		{
			PluginAddNonZeroAllKeys(sourceAnimationId, targetAnimationId, frameId);
		}
		/// <summary>
		/// Add source color to target where color is not black for all frames, reference 
		/// source and target by id.
		/// </summary>
		public static void AddNonZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId)
		{
			PluginAddNonZeroAllKeysAllFrames(sourceAnimationId, targetAnimationId);
		}
		/// <summary>
		/// Add source color to target where color is not black for all frames, reference 
		/// source and target by name.
		/// </summary>
		public static void AddNonZeroAllKeysAllFramesName(string sourceAnimation, string targetAnimation)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginAddNonZeroAllKeysAllFramesName(lp_SourceAnimation, lp_TargetAnimation);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double AddNonZeroAllKeysAllFramesNameD(string sourceAnimation, string targetAnimation)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginAddNonZeroAllKeysAllFramesNameD(lp_SourceAnimation, lp_TargetAnimation);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Add source color to target where color is not black for all frames starting 
		/// at offset for the length of the source, reference source and target by 
		/// id.
		/// </summary>
		public static void AddNonZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset)
		{
			PluginAddNonZeroAllKeysAllFramesOffset(sourceAnimationId, targetAnimationId, offset);
		}
		/// <summary>
		/// Add source color to target where color is not black for all frames starting 
		/// at offset for the length of the source, reference source and target by 
		/// name.
		/// </summary>
		public static void AddNonZeroAllKeysAllFramesOffsetName(string sourceAnimation, string targetAnimation, int offset)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginAddNonZeroAllKeysAllFramesOffsetName(lp_SourceAnimation, lp_TargetAnimation, offset);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double AddNonZeroAllKeysAllFramesOffsetNameD(string sourceAnimation, string targetAnimation, double offset)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginAddNonZeroAllKeysAllFramesOffsetNameD(lp_SourceAnimation, lp_TargetAnimation, offset);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Add source color to target where color is not black for frame id, reference 
		/// source and target by name.
		/// </summary>
		public static void AddNonZeroAllKeysName(string sourceAnimation, string targetAnimation, int frameId)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginAddNonZeroAllKeysName(lp_SourceAnimation, lp_TargetAnimation, frameId);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// Add source color to target where color is not black for the source frame 
		/// and target offset frame, reference source and target by id.
		/// </summary>
		public static void AddNonZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset)
		{
			PluginAddNonZeroAllKeysOffset(sourceAnimationId, targetAnimationId, frameId, offset);
		}
		/// <summary>
		/// Add source color to target where color is not black for the source frame 
		/// and target offset frame, reference source and target by name.
		/// </summary>
		public static void AddNonZeroAllKeysOffsetName(string sourceAnimation, string targetAnimation, int frameId, int offset)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginAddNonZeroAllKeysOffsetName(lp_SourceAnimation, lp_TargetAnimation, frameId, offset);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double AddNonZeroAllKeysOffsetNameD(string sourceAnimation, string targetAnimation, double frameId, double offset)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginAddNonZeroAllKeysOffsetNameD(lp_SourceAnimation, lp_TargetAnimation, frameId, offset);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Add source color to target where the target color is not black for all frames, 
		/// reference source and target by id.
		/// </summary>
		public static void AddNonZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId)
		{
			PluginAddNonZeroTargetAllKeysAllFrames(sourceAnimationId, targetAnimationId);
		}
		/// <summary>
		/// Add source color to target where the target color is not black for all frames, 
		/// reference source and target by name.
		/// </summary>
		public static void AddNonZeroTargetAllKeysAllFramesName(string sourceAnimation, string targetAnimation)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginAddNonZeroTargetAllKeysAllFramesName(lp_SourceAnimation, lp_TargetAnimation);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double AddNonZeroTargetAllKeysAllFramesNameD(string sourceAnimation, string targetAnimation)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginAddNonZeroTargetAllKeysAllFramesNameD(lp_SourceAnimation, lp_TargetAnimation);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Add source color to target where the target color is not black for all frames 
		/// starting at offset for the length of the source, reference source and target 
		/// by id.
		/// </summary>
		public static void AddNonZeroTargetAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset)
		{
			PluginAddNonZeroTargetAllKeysAllFramesOffset(sourceAnimationId, targetAnimationId, offset);
		}
		/// <summary>
		/// Add source color to target where the target color is not black for all frames 
		/// starting at offset for the length of the source, reference source and target 
		/// by name.
		/// </summary>
		public static void AddNonZeroTargetAllKeysAllFramesOffsetName(string sourceAnimation, string targetAnimation, int offset)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginAddNonZeroTargetAllKeysAllFramesOffsetName(lp_SourceAnimation, lp_TargetAnimation, offset);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double AddNonZeroTargetAllKeysAllFramesOffsetNameD(string sourceAnimation, string targetAnimation, double offset)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginAddNonZeroTargetAllKeysAllFramesOffsetNameD(lp_SourceAnimation, lp_TargetAnimation, offset);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Add source color to target where target color is not blank from the source 
		/// frame to the target offset frame, reference source and target by id.
		/// </summary>
		public static void AddNonZeroTargetAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset)
		{
			PluginAddNonZeroTargetAllKeysOffset(sourceAnimationId, targetAnimationId, frameId, offset);
		}
		/// <summary>
		/// Add source color to target where target color is not blank from the source 
		/// frame to the target offset frame, reference source and target by name. 
		///
		/// </summary>
		public static void AddNonZeroTargetAllKeysOffsetName(string sourceAnimation, string targetAnimation, int frameId, int offset)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginAddNonZeroTargetAllKeysOffsetName(lp_SourceAnimation, lp_TargetAnimation, frameId, offset);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double AddNonZeroTargetAllKeysOffsetNameD(string sourceAnimation, string targetAnimation, double frameId, double offset)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginAddNonZeroTargetAllKeysOffsetNameD(lp_SourceAnimation, lp_TargetAnimation, frameId, offset);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Append all source frames to the target animation, reference source and target 
		/// by id.
		/// </summary>
		public static void AppendAllFrames(int sourceAnimationId, int targetAnimationId)
		{
			PluginAppendAllFrames(sourceAnimationId, targetAnimationId);
		}
		/// <summary>
		/// Append all source frames to the target animation, reference source and target 
		/// by name.
		/// </summary>
		public static void AppendAllFramesName(string sourceAnimation, string targetAnimation)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginAppendAllFramesName(lp_SourceAnimation, lp_TargetAnimation);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double AppendAllFramesNameD(string sourceAnimation, string targetAnimation)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginAppendAllFramesNameD(lp_SourceAnimation, lp_TargetAnimation);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// `PluginClearAll` will issue a `CLEAR` effect for all devices.
		/// </summary>
		public static void ClearAll()
		{
			PluginClearAll();
		}
		/// <summary>
		/// `PluginClearAnimationType` will issue a `CLEAR` effect for the given device. 
		///
		/// </summary>
		public static void ClearAnimationType(int deviceType, int device)
		{
			PluginClearAnimationType(deviceType, device);
		}
		/// <summary>
		/// `PluginCloseAll` closes all open animations so they can be reloaded from 
		/// disk. The set of animations will be stopped if playing.
		/// </summary>
		public static void CloseAll()
		{
			PluginCloseAll();
		}
		/// <summary>
		/// Closes the `Chroma` animation to free up resources referenced by id. Returns 
		/// the animation id upon success. Returns negative one upon failure. This 
		/// might be used while authoring effects if there was a change necessitating 
		/// re-opening the animation. The animation id can no longer be used once closed. 
		///
		/// </summary>
		public static int CloseAnimation(int animationId)
		{
			int result = PluginCloseAnimation(animationId);
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double CloseAnimationD(double animationId)
		{
			double result = PluginCloseAnimationD(animationId);
			return result;
		}
		/// <summary>
		/// Closes the `Chroma` animation referenced by name so that the animation can 
		/// be reloaded from disk.
		/// </summary>
		public static void CloseAnimationName(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginCloseAnimationName(lp_Path);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double CloseAnimationNameD(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginCloseAnimationNameD(lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// `PluginCloseComposite` closes a set of animations so they can be reloaded 
		/// from disk. The set of animations will be stopped if playing.
		/// </summary>
		public static void CloseComposite(string name)
		{
			string str_Name = name;
			IntPtr lp_Name = GetPathIntPtr(str_Name);
			PluginCloseComposite(lp_Name);
			FreeIntPtr(lp_Name);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double CloseCompositeD(string name)
		{
			string str_Name = name;
			IntPtr lp_Name = GetPathIntPtr(str_Name);
			double result = PluginCloseCompositeD(lp_Name);
			FreeIntPtr(lp_Name);
			return result;
		}
		/// <summary>
		/// Copy source animation to target animation for the given frame. Source and 
		/// target are referenced by id.
		/// </summary>
		public static void CopyAllKeys(int sourceAnimationId, int targetAnimationId, int frameId)
		{
			PluginCopyAllKeys(sourceAnimationId, targetAnimationId, frameId);
		}
		/// <summary>
		/// Copy source animation to target animation for the given frame. Source and 
		/// target are referenced by id.
		/// </summary>
		public static void CopyAllKeysName(string sourceAnimation, string targetAnimation, int frameId)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginCopyAllKeysName(lp_SourceAnimation, lp_TargetAnimation, frameId);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// Copy animation to named target animation in memory. If target animation 
		/// exists, close first. Source is referenced by id.
		/// </summary>
		public static int CopyAnimation(int sourceAnimationId, string targetAnimation)
		{
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			int result = PluginCopyAnimation(sourceAnimationId, lp_TargetAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Copy animation to named target animation in memory. If target animation 
		/// exists, close first. Source is referenced by name.
		/// </summary>
		public static void CopyAnimationName(string sourceAnimation, string targetAnimation)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginCopyAnimationName(lp_SourceAnimation, lp_TargetAnimation);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double CopyAnimationNameD(string sourceAnimation, string targetAnimation)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginCopyAnimationNameD(lp_SourceAnimation, lp_TargetAnimation);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Copy blue channel to other channels for all frames. Intensity range is 0.0 
		/// to 1.0. Reference the animation by id.
		/// </summary>
		public static void CopyBlueChannelAllFrames(int animationId, float redIntensity, float greenIntensity)
		{
			PluginCopyBlueChannelAllFrames(animationId, redIntensity, greenIntensity);
		}
		/// <summary>
		/// Copy blue channel to other channels for all frames. Intensity range is 0.0 
		/// to 1.0. Reference the animation by name.
		/// </summary>
		public static void CopyBlueChannelAllFramesName(string path, float redIntensity, float greenIntensity)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginCopyBlueChannelAllFramesName(lp_Path, redIntensity, greenIntensity);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double CopyBlueChannelAllFramesNameD(string path, double redIntensity, double greenIntensity)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginCopyBlueChannelAllFramesNameD(lp_Path, redIntensity, greenIntensity);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Copy green channel to other channels for all frames. Intensity range is 
		/// 0.0 to 1.0. Reference the animation by id.
		/// </summary>
		public static void CopyGreenChannelAllFrames(int animationId, float redIntensity, float blueIntensity)
		{
			PluginCopyGreenChannelAllFrames(animationId, redIntensity, blueIntensity);
		}
		/// <summary>
		/// Copy green channel to other channels for all frames. Intensity range is 
		/// 0.0 to 1.0. Reference the animation by name.
		/// </summary>
		public static void CopyGreenChannelAllFramesName(string path, float redIntensity, float blueIntensity)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginCopyGreenChannelAllFramesName(lp_Path, redIntensity, blueIntensity);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double CopyGreenChannelAllFramesNameD(string path, double redIntensity, double blueIntensity)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginCopyGreenChannelAllFramesNameD(lp_Path, redIntensity, blueIntensity);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Copy animation key color from the source animation to the target animation 
		/// for the given frame. Reference the source and target by id.
		/// </summary>
		public static void CopyKeyColor(int sourceAnimationId, int targetAnimationId, int frameId, int rzkey)
		{
			PluginCopyKeyColor(sourceAnimationId, targetAnimationId, frameId, rzkey);
		}
		/// <summary>
		/// Copy animation key color from the source animation to the target animation 
		/// for all frames. Reference the source and target by id.
		/// </summary>
		public static void CopyKeyColorAllFrames(int sourceAnimationId, int targetAnimationId, int rzkey)
		{
			PluginCopyKeyColorAllFrames(sourceAnimationId, targetAnimationId, rzkey);
		}
		/// <summary>
		/// Copy animation key color from the source animation to the target animation 
		/// for all frames. Reference the source and target by name.
		/// </summary>
		public static void CopyKeyColorAllFramesName(string sourceAnimation, string targetAnimation, int rzkey)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginCopyKeyColorAllFramesName(lp_SourceAnimation, lp_TargetAnimation, rzkey);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double CopyKeyColorAllFramesNameD(string sourceAnimation, string targetAnimation, double rzkey)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginCopyKeyColorAllFramesNameD(lp_SourceAnimation, lp_TargetAnimation, rzkey);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Copy animation key color from the source animation to the target animation 
		/// for all frames, starting at the offset for the length of the source animation. 
		/// Source and target are referenced by id.
		/// </summary>
		public static void CopyKeyColorAllFramesOffset(int sourceAnimationId, int targetAnimationId, int rzkey, int offset)
		{
			PluginCopyKeyColorAllFramesOffset(sourceAnimationId, targetAnimationId, rzkey, offset);
		}
		/// <summary>
		/// Copy animation key color from the source animation to the target animation 
		/// for all frames, starting at the offset for the length of the source animation. 
		/// Source and target are referenced by name.
		/// </summary>
		public static void CopyKeyColorAllFramesOffsetName(string sourceAnimation, string targetAnimation, int rzkey, int offset)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginCopyKeyColorAllFramesOffsetName(lp_SourceAnimation, lp_TargetAnimation, rzkey, offset);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double CopyKeyColorAllFramesOffsetNameD(string sourceAnimation, string targetAnimation, double rzkey, double offset)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginCopyKeyColorAllFramesOffsetNameD(lp_SourceAnimation, lp_TargetAnimation, rzkey, offset);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Copy animation key color from the source animation to the target animation 
		/// for the given frame.
		/// </summary>
		public static void CopyKeyColorName(string sourceAnimation, string targetAnimation, int frameId, int rzkey)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginCopyKeyColorName(lp_SourceAnimation, lp_TargetAnimation, frameId, rzkey);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double CopyKeyColorNameD(string sourceAnimation, string targetAnimation, double frameId, double rzkey)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginCopyKeyColorNameD(lp_SourceAnimation, lp_TargetAnimation, frameId, rzkey);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Copy animation color for a set of keys from the source animation to the 
		/// target animation for the given frame. Reference the source and target by 
		/// id.
		/// </summary>
		public static void CopyKeysColor(int sourceAnimationId, int targetAnimationId, int frameId, int[] keys, int size)
		{
			PluginCopyKeysColor(sourceAnimationId, targetAnimationId, frameId, keys, size);
		}
		/// <summary>
		/// Copy animation color for a set of keys from the source animation to the 
		/// target animation for all frames. Reference the source and target by id. 
		///
		/// </summary>
		public static void CopyKeysColorAllFrames(int sourceAnimationId, int targetAnimationId, int[] keys, int size)
		{
			PluginCopyKeysColorAllFrames(sourceAnimationId, targetAnimationId, keys, size);
		}
		/// <summary>
		/// Copy animation color for a set of keys from the source animation to the 
		/// target animation for all frames. Reference the source and target by name. 
		///
		/// </summary>
		public static void CopyKeysColorAllFramesName(string sourceAnimation, string targetAnimation, int[] keys, int size)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginCopyKeysColorAllFramesName(lp_SourceAnimation, lp_TargetAnimation, keys, size);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// Copy animation color for a set of keys from the source animation to the 
		/// target animation for the given frame. Reference the source and target by 
		/// name.
		/// </summary>
		public static void CopyKeysColorName(string sourceAnimation, string targetAnimation, int frameId, int[] keys, int size)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginCopyKeysColorName(lp_SourceAnimation, lp_TargetAnimation, frameId, keys, size);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// Copy animation color for a set of keys from the source animation to the 
		/// target animation from the source frame to the target frame. Reference the 
		/// source and target by id.
		/// </summary>
		public static void CopyKeysColorOffset(int sourceAnimationId, int targetAnimationId, int sourceFrameId, int targetFrameId, int[] keys, int size)
		{
			PluginCopyKeysColorOffset(sourceAnimationId, targetAnimationId, sourceFrameId, targetFrameId, keys, size);
		}
		/// <summary>
		/// Copy animation color for a set of keys from the source animation to the 
		/// target animation from the source frame to the target frame. Reference the 
		/// source and target by name.
		/// </summary>
		public static void CopyKeysColorOffsetName(string sourceAnimation, string targetAnimation, int sourceFrameId, int targetFrameId, int[] keys, int size)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginCopyKeysColorOffsetName(lp_SourceAnimation, lp_TargetAnimation, sourceFrameId, targetFrameId, keys, size);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// Copy source animation to target animation for the given frame. Source and 
		/// target are referenced by id.
		/// </summary>
		public static void CopyNonZeroAllKeys(int sourceAnimationId, int targetAnimationId, int frameId)
		{
			PluginCopyNonZeroAllKeys(sourceAnimationId, targetAnimationId, frameId);
		}
		/// <summary>
		/// Copy nonzero colors from a source animation to a target animation for all 
		/// frames. Reference source and target by id.
		/// </summary>
		public static void CopyNonZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId)
		{
			PluginCopyNonZeroAllKeysAllFrames(sourceAnimationId, targetAnimationId);
		}
		/// <summary>
		/// Copy nonzero colors from a source animation to a target animation for all 
		/// frames. Reference source and target by name.
		/// </summary>
		public static void CopyNonZeroAllKeysAllFramesName(string sourceAnimation, string targetAnimation)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginCopyNonZeroAllKeysAllFramesName(lp_SourceAnimation, lp_TargetAnimation);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double CopyNonZeroAllKeysAllFramesNameD(string sourceAnimation, string targetAnimation)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginCopyNonZeroAllKeysAllFramesNameD(lp_SourceAnimation, lp_TargetAnimation);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Copy nonzero colors from a source animation to a target animation for all 
		/// frames starting at the offset for the length of the source animation. The 
		/// source and target are referenced by id.
		/// </summary>
		public static void CopyNonZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset)
		{
			PluginCopyNonZeroAllKeysAllFramesOffset(sourceAnimationId, targetAnimationId, offset);
		}
		/// <summary>
		/// Copy nonzero colors from a source animation to a target animation for all 
		/// frames starting at the offset for the length of the source animation. The 
		/// source and target are referenced by name.
		/// </summary>
		public static void CopyNonZeroAllKeysAllFramesOffsetName(string sourceAnimation, string targetAnimation, int offset)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginCopyNonZeroAllKeysAllFramesOffsetName(lp_SourceAnimation, lp_TargetAnimation, offset);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double CopyNonZeroAllKeysAllFramesOffsetNameD(string sourceAnimation, string targetAnimation, double offset)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginCopyNonZeroAllKeysAllFramesOffsetNameD(lp_SourceAnimation, lp_TargetAnimation, offset);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Copy nonzero colors from source animation to target animation for the specified 
		/// frame. Source and target are referenced by id.
		/// </summary>
		public static void CopyNonZeroAllKeysName(string sourceAnimation, string targetAnimation, int frameId)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginCopyNonZeroAllKeysName(lp_SourceAnimation, lp_TargetAnimation, frameId);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double CopyNonZeroAllKeysNameD(string sourceAnimation, string targetAnimation, double frameId)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginCopyNonZeroAllKeysNameD(lp_SourceAnimation, lp_TargetAnimation, frameId);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Copy nonzero colors from the source animation to the target animation from 
		/// the source frame to the target offset frame. Source and target are referenced 
		/// by id.
		/// </summary>
		public static void CopyNonZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset)
		{
			PluginCopyNonZeroAllKeysOffset(sourceAnimationId, targetAnimationId, frameId, offset);
		}
		/// <summary>
		/// Copy nonzero colors from the source animation to the target animation from 
		/// the source frame to the target offset frame. Source and target are referenced 
		/// by name.
		/// </summary>
		public static void CopyNonZeroAllKeysOffsetName(string sourceAnimation, string targetAnimation, int frameId, int offset)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginCopyNonZeroAllKeysOffsetName(lp_SourceAnimation, lp_TargetAnimation, frameId, offset);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double CopyNonZeroAllKeysOffsetNameD(string sourceAnimation, string targetAnimation, double frameId, double offset)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginCopyNonZeroAllKeysOffsetNameD(lp_SourceAnimation, lp_TargetAnimation, frameId, offset);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Copy animation key color from the source animation to the target animation 
		/// for the given frame where color is not zero.
		/// </summary>
		public static void CopyNonZeroKeyColor(int sourceAnimationId, int targetAnimationId, int frameId, int rzkey)
		{
			PluginCopyNonZeroKeyColor(sourceAnimationId, targetAnimationId, frameId, rzkey);
		}
		/// <summary>
		/// Copy animation key color from the source animation to the target animation 
		/// for the given frame where color is not zero.
		/// </summary>
		public static void CopyNonZeroKeyColorName(string sourceAnimation, string targetAnimation, int frameId, int rzkey)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginCopyNonZeroKeyColorName(lp_SourceAnimation, lp_TargetAnimation, frameId, rzkey);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double CopyNonZeroKeyColorNameD(string sourceAnimation, string targetAnimation, double frameId, double rzkey)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginCopyNonZeroKeyColorNameD(lp_SourceAnimation, lp_TargetAnimation, frameId, rzkey);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Copy nonzero colors from the source animation to the target animation where 
		/// the target color is nonzero for the specified frame. Source and target 
		/// are referenced by id.
		/// </summary>
		public static void CopyNonZeroTargetAllKeys(int sourceAnimationId, int targetAnimationId, int frameId)
		{
			PluginCopyNonZeroTargetAllKeys(sourceAnimationId, targetAnimationId, frameId);
		}
		/// <summary>
		/// Copy nonzero colors from the source animation to the target animation where 
		/// the target color is nonzero for all frames. Source and target are referenced 
		/// by id.
		/// </summary>
		public static void CopyNonZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId)
		{
			PluginCopyNonZeroTargetAllKeysAllFrames(sourceAnimationId, targetAnimationId);
		}
		/// <summary>
		/// Copy nonzero colors from the source animation to the target animation where 
		/// the target color is nonzero for all frames. Source and target are referenced 
		/// by name.
		/// </summary>
		public static void CopyNonZeroTargetAllKeysAllFramesName(string sourceAnimation, string targetAnimation)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginCopyNonZeroTargetAllKeysAllFramesName(lp_SourceAnimation, lp_TargetAnimation);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double CopyNonZeroTargetAllKeysAllFramesNameD(string sourceAnimation, string targetAnimation)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginCopyNonZeroTargetAllKeysAllFramesNameD(lp_SourceAnimation, lp_TargetAnimation);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Copy nonzero colors from the source animation to the target animation where 
		/// the target color is nonzero for all frames. Source and target are referenced 
		/// by name.
		/// </summary>
		public static void CopyNonZeroTargetAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset)
		{
			PluginCopyNonZeroTargetAllKeysAllFramesOffset(sourceAnimationId, targetAnimationId, offset);
		}
		/// <summary>
		/// Copy nonzero colors from the source animation to the target animation where 
		/// the target color is nonzero for all frames starting at the target offset 
		/// for the length of the source animation. Source and target animations are 
		/// referenced by name.
		/// </summary>
		public static void CopyNonZeroTargetAllKeysAllFramesOffsetName(string sourceAnimation, string targetAnimation, int offset)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginCopyNonZeroTargetAllKeysAllFramesOffsetName(lp_SourceAnimation, lp_TargetAnimation, offset);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double CopyNonZeroTargetAllKeysAllFramesOffsetNameD(string sourceAnimation, string targetAnimation, double offset)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginCopyNonZeroTargetAllKeysAllFramesOffsetNameD(lp_SourceAnimation, lp_TargetAnimation, offset);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Copy nonzero colors from the source animation to the target animation where 
		/// the target color is nonzero for the specified frame. The source and target 
		/// are referenced by name.
		/// </summary>
		public static void CopyNonZeroTargetAllKeysName(string sourceAnimation, string targetAnimation, int frameId)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginCopyNonZeroTargetAllKeysName(lp_SourceAnimation, lp_TargetAnimation, frameId);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double CopyNonZeroTargetAllKeysNameD(string sourceAnimation, string targetAnimation, double frameId)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginCopyNonZeroTargetAllKeysNameD(lp_SourceAnimation, lp_TargetAnimation, frameId);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Copy nonzero colors from the source animation to the target animation where 
		/// the target color is nonzero for the specified source frame and target offset 
		/// frame. The source and target are referenced by id.
		/// </summary>
		public static void CopyNonZeroTargetAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset)
		{
			PluginCopyNonZeroTargetAllKeysOffset(sourceAnimationId, targetAnimationId, frameId, offset);
		}
		/// <summary>
		/// Copy nonzero colors from the source animation to the target animation where 
		/// the target color is nonzero for the specified source frame and target offset 
		/// frame. The source and target are referenced by name.
		/// </summary>
		public static void CopyNonZeroTargetAllKeysOffsetName(string sourceAnimation, string targetAnimation, int frameId, int offset)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginCopyNonZeroTargetAllKeysOffsetName(lp_SourceAnimation, lp_TargetAnimation, frameId, offset);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double CopyNonZeroTargetAllKeysOffsetNameD(string sourceAnimation, string targetAnimation, double frameId, double offset)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginCopyNonZeroTargetAllKeysOffsetNameD(lp_SourceAnimation, lp_TargetAnimation, frameId, offset);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Copy nonzero colors from the source animation to the target animation where 
		/// the target color is zero for all frames. Source and target are referenced 
		/// by id.
		/// </summary>
		public static void CopyNonZeroTargetZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId)
		{
			PluginCopyNonZeroTargetZeroAllKeysAllFrames(sourceAnimationId, targetAnimationId);
		}
		/// <summary>
		/// Copy nonzero colors from the source animation to the target animation where 
		/// the target color is zero for all frames. Source and target are referenced 
		/// by name.
		/// </summary>
		public static void CopyNonZeroTargetZeroAllKeysAllFramesName(string sourceAnimation, string targetAnimation)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginCopyNonZeroTargetZeroAllKeysAllFramesName(lp_SourceAnimation, lp_TargetAnimation);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double CopyNonZeroTargetZeroAllKeysAllFramesNameD(string sourceAnimation, string targetAnimation)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginCopyNonZeroTargetZeroAllKeysAllFramesNameD(lp_SourceAnimation, lp_TargetAnimation);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Copy red channel to other channels for all frames. Intensity range is 0.0 
		/// to 1.0. Reference the animation by id.
		/// </summary>
		public static void CopyRedChannelAllFrames(int animationId, float greenIntensity, float blueIntensity)
		{
			PluginCopyRedChannelAllFrames(animationId, greenIntensity, blueIntensity);
		}
		/// <summary>
		/// Copy green channel to other channels for all frames. Intensity range is 
		/// 0.0 to 1.0. Reference the animation by name.
		/// </summary>
		public static void CopyRedChannelAllFramesName(string path, float greenIntensity, float blueIntensity)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginCopyRedChannelAllFramesName(lp_Path, greenIntensity, blueIntensity);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double CopyRedChannelAllFramesNameD(string path, double greenIntensity, double blueIntensity)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginCopyRedChannelAllFramesNameD(lp_Path, greenIntensity, blueIntensity);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Copy zero colors from source animation to target animation for the frame. 
		/// Source and target are referenced by id.
		/// </summary>
		public static void CopyZeroAllKeys(int sourceAnimationId, int targetAnimationId, int frameId)
		{
			PluginCopyZeroAllKeys(sourceAnimationId, targetAnimationId, frameId);
		}
		/// <summary>
		/// Copy zero colors from source animation to target animation for all frames. 
		/// Source and target are referenced by id.
		/// </summary>
		public static void CopyZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId)
		{
			PluginCopyZeroAllKeysAllFrames(sourceAnimationId, targetAnimationId);
		}
		/// <summary>
		/// Copy zero colors from source animation to target animation for all frames. 
		/// Source and target are referenced by name.
		/// </summary>
		public static void CopyZeroAllKeysAllFramesName(string sourceAnimation, string targetAnimation)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginCopyZeroAllKeysAllFramesName(lp_SourceAnimation, lp_TargetAnimation);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double CopyZeroAllKeysAllFramesNameD(string sourceAnimation, string targetAnimation)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginCopyZeroAllKeysAllFramesNameD(lp_SourceAnimation, lp_TargetAnimation);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Copy zero colors from source animation to target animation for all frames 
		/// starting at the target offset for the length of the source animation. Source 
		/// and target are referenced by id.
		/// </summary>
		public static void CopyZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset)
		{
			PluginCopyZeroAllKeysAllFramesOffset(sourceAnimationId, targetAnimationId, offset);
		}
		/// <summary>
		/// Copy zero colors from source animation to target animation for all frames 
		/// starting at the target offset for the length of the source animation. Source 
		/// and target are referenced by name.
		/// </summary>
		public static void CopyZeroAllKeysAllFramesOffsetName(string sourceAnimation, string targetAnimation, int offset)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginCopyZeroAllKeysAllFramesOffsetName(lp_SourceAnimation, lp_TargetAnimation, offset);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double CopyZeroAllKeysAllFramesOffsetNameD(string sourceAnimation, string targetAnimation, double offset)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginCopyZeroAllKeysAllFramesOffsetNameD(lp_SourceAnimation, lp_TargetAnimation, offset);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Copy zero colors from source animation to target animation for the frame. 
		/// Source and target are referenced by name.
		/// </summary>
		public static void CopyZeroAllKeysName(string sourceAnimation, string targetAnimation, int frameId)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginCopyZeroAllKeysName(lp_SourceAnimation, lp_TargetAnimation, frameId);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// Copy zero colors from source animation to target animation for the frame 
		/// id starting at the target offset for the length of the source animation. 
		/// Source and target are referenced by id.
		/// </summary>
		public static void CopyZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset)
		{
			PluginCopyZeroAllKeysOffset(sourceAnimationId, targetAnimationId, frameId, offset);
		}
		/// <summary>
		/// Copy zero colors from source animation to target animation for the frame 
		/// id starting at the target offset for the length of the source animation. 
		/// Source and target are referenced by name.
		/// </summary>
		public static void CopyZeroAllKeysOffsetName(string sourceAnimation, string targetAnimation, int frameId, int offset)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginCopyZeroAllKeysOffsetName(lp_SourceAnimation, lp_TargetAnimation, frameId, offset);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// Copy zero key color from source animation to target animation for the specified 
		/// frame. Source and target are referenced by id.
		/// </summary>
		public static void CopyZeroKeyColor(int sourceAnimationId, int targetAnimationId, int frameId, int rzkey)
		{
			PluginCopyZeroKeyColor(sourceAnimationId, targetAnimationId, frameId, rzkey);
		}
		/// <summary>
		/// Copy zero key color from source animation to target animation for the specified 
		/// frame. Source and target are referenced by name.
		/// </summary>
		public static void CopyZeroKeyColorName(string sourceAnimation, string targetAnimation, int frameId, int rzkey)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginCopyZeroKeyColorName(lp_SourceAnimation, lp_TargetAnimation, frameId, rzkey);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double CopyZeroKeyColorNameD(string sourceAnimation, string targetAnimation, double frameId, double rzkey)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginCopyZeroKeyColorNameD(lp_SourceAnimation, lp_TargetAnimation, frameId, rzkey);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Copy nonzero color from source animation to target animation where target 
		/// is zero for the frame. Source and target are referenced by id.
		/// </summary>
		public static void CopyZeroTargetAllKeys(int sourceAnimationId, int targetAnimationId, int frameId)
		{
			PluginCopyZeroTargetAllKeys(sourceAnimationId, targetAnimationId, frameId);
		}
		/// <summary>
		/// Copy nonzero color from source animation to target animation where target 
		/// is zero for all frames. Source and target are referenced by id.
		/// </summary>
		public static void CopyZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId)
		{
			PluginCopyZeroTargetAllKeysAllFrames(sourceAnimationId, targetAnimationId);
		}
		/// <summary>
		/// Copy nonzero color from source animation to target animation where target 
		/// is zero for all frames. Source and target are referenced by name.
		/// </summary>
		public static void CopyZeroTargetAllKeysAllFramesName(string sourceAnimation, string targetAnimation)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginCopyZeroTargetAllKeysAllFramesName(lp_SourceAnimation, lp_TargetAnimation);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double CopyZeroTargetAllKeysAllFramesNameD(string sourceAnimation, string targetAnimation)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginCopyZeroTargetAllKeysAllFramesNameD(lp_SourceAnimation, lp_TargetAnimation);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Copy nonzero color from source animation to target animation where target 
		/// is zero for the frame. Source and target are referenced by name.
		/// </summary>
		public static void CopyZeroTargetAllKeysName(string sourceAnimation, string targetAnimation, int frameId)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginCopyZeroTargetAllKeysName(lp_SourceAnimation, lp_TargetAnimation, frameId);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// Direct access to low level API.
		/// </summary>
		public static int CoreCreateChromaLinkEffect(int effect, IntPtr pParam, out Guid pEffectId)
		{
			int result = PluginCoreCreateChromaLinkEffect(effect, pParam, out pEffectId);
			return result;
		}
		/// <summary>
		/// Direct access to low level API.
		/// </summary>
		public static int CoreCreateEffect(Guid deviceId, EFFECT_TYPE effect, IntPtr pParam, out Guid pEffectId)
		{
			int result = PluginCoreCreateEffect(deviceId, (int)effect, pParam, out pEffectId);
			return result;
		}
		/// <summary>
		/// Direct access to low level API.
		/// </summary>
		public static int CoreCreateHeadsetEffect(int effect, IntPtr pParam, out Guid pEffectId)
		{
			int result = PluginCoreCreateHeadsetEffect(effect, pParam, out pEffectId);
			return result;
		}
		/// <summary>
		/// Direct access to low level API.
		/// </summary>
		public static int CoreCreateKeyboardEffect(int effect, IntPtr pParam, out Guid pEffectId)
		{
			int result = PluginCoreCreateKeyboardEffect(effect, pParam, out pEffectId);
			return result;
		}
		/// <summary>
		/// Direct access to low level API.
		/// </summary>
		public static int CoreCreateKeypadEffect(int effect, IntPtr pParam, out Guid pEffectId)
		{
			int result = PluginCoreCreateKeypadEffect(effect, pParam, out pEffectId);
			return result;
		}
		/// <summary>
		/// Direct access to low level API.
		/// </summary>
		public static int CoreCreateMouseEffect(int effect, IntPtr pParam, out Guid pEffectId)
		{
			int result = PluginCoreCreateMouseEffect(effect, pParam, out pEffectId);
			return result;
		}
		/// <summary>
		/// Direct access to low level API.
		/// </summary>
		public static int CoreCreateMousepadEffect(int effect, IntPtr pParam, out Guid pEffectId)
		{
			int result = PluginCoreCreateMousepadEffect(effect, pParam, out pEffectId);
			return result;
		}
		/// <summary>
		/// Direct access to low level API.
		/// </summary>
		public static int CoreDeleteEffect(Guid effectId)
		{
			int result = PluginCoreDeleteEffect(effectId);
			return result;
		}
		/// <summary>
		/// Direct access to low level API.
		/// </summary>
		public static int CoreInit()
		{
			int result = PluginCoreInit();
			return result;
		}
		/// <summary>
		/// Direct access to low level API.
		/// </summary>
		public static int CoreInitSDK(ref ChromaSDK.APPINFOTYPE appInfo)
		{
			int result = PluginCoreInitSDK(ref appInfo);
			return result;
		}
		/// <summary>
		/// Direct access to low level API.
		/// </summary>
		public static int CoreQueryDevice(Guid deviceId, out DEVICE_INFO_TYPE deviceInfo)
		{
			int result = PluginCoreQueryDevice(deviceId, out deviceInfo);
			return result;
		}
		/// <summary>
		/// Direct access to low level API.
		/// </summary>
		public static int CoreSetEffect(Guid effectId)
		{
			int result = PluginCoreSetEffect(effectId);
			return result;
		}
		/// <summary>
		/// Begin broadcasting Chroma RGB data using the stored stream key as the endpoint. 
		/// Intended for Cloud Gaming Platforms,  restore the streaming key when the 
		/// game instance is launched to continue streaming.  streamId is a null terminated 
		/// string  streamKey is a null terminated string  StreamGetStatus() should 
		/// return the READY status to use this method.
		/// </summary>
		public static bool CoreStreamBroadcast(string streamId, string streamKey)
		{
			string str_StreamId = streamId;
			IntPtr lp_StreamId = GetAsciiIntPtr(str_StreamId);
			string str_StreamKey = streamKey;
			IntPtr lp_StreamKey = GetAsciiIntPtr(str_StreamKey);
			bool result = PluginCoreStreamBroadcast(lp_StreamId, lp_StreamKey);
			FreeIntPtr(lp_StreamId);
			FreeIntPtr(lp_StreamKey);
			return result;
		}
		/// <summary>
		/// End broadcasting Chroma RGB data.  StreamGetStatus() should return the BROADCASTING 
		/// status to use this method.
		/// </summary>
		public static bool CoreStreamBroadcastEnd()
		{
			bool result = PluginCoreStreamBroadcastEnd();
			return result;
		}
		/// <summary>
		/// shortcode: Pass the address of a preallocated character buffer to get the 
		/// streaming auth code. The buffer should have a minimum length of 6.  length: 
		/// Length will return as zero if the streaming auth code could not be obtained. 
		/// If length is greater than zero, it will be the length of the returned streaming 
		/// auth code.  Once you have the shortcode, it should be shown to the user 
		/// so they can associate the stream with their Razer ID  StreamGetStatus() 
		/// should return the READY status before invoking this method. platform: is 
		/// the null terminated string that identifies the source of the stream: { 
		/// GEFORCE_NOW, LUNA, STADIA, GAME_PASS } title: is the null terminated string 
		/// that identifies the application or game.
		/// </summary>
		public static void CoreStreamGetAuthShortcode(ref string shortcode, out byte length, string platform, string title)
		{
			string str_Shortcode = shortcode;
			IntPtr lp_Shortcode = GetAsciiIntPtr(str_Shortcode);
			string str_Platform = platform;
			IntPtr lp_Platform = GetUnicodeIntPtr(str_Platform);
			string str_Title = title;
			IntPtr lp_Title = GetUnicodeIntPtr(str_Title);
			PluginCoreStreamGetAuthShortcode(lp_Shortcode, out length, lp_Platform, lp_Title);
			if (lp_Shortcode != IntPtr.Zero)
			{
				shortcode = Marshal.PtrToStringAnsi(lp_Shortcode);
			}
			FreeIntPtr(lp_Shortcode);
			FreeIntPtr(lp_Platform);
			FreeIntPtr(lp_Title);
		}
		/// <summary>
		/// focus: Pass the address of a preallocated character buffer to get the stream 
		/// focus. The buffer should have a length of 48  length: Length will return 
		/// as zero if the stream focus could not be obtained. If length is greater 
		/// than zero, it will be the length of the returned stream focus.
		/// </summary>
		public static bool CoreStreamGetFocus(ref string focus, out byte length)
		{
			string str_Focus = focus;
			IntPtr lp_Focus = GetAsciiIntPtr(str_Focus);
			bool result = PluginCoreStreamGetFocus(lp_Focus, out length);
			if (lp_Focus != IntPtr.Zero)
			{
				focus = Marshal.PtrToStringAnsi(lp_Focus);
			}
			FreeIntPtr(lp_Focus);
			return result;
		}
		/// <summary>
		/// Intended for Cloud Gaming Platforms, store the stream id to persist in user 
		/// preferences to continue streaming if the game is suspended or closed. shortcode: 
		/// The shortcode is a null terminated string. Use the shortcode that authorized 
		/// the stream to obtain the stream id.  streamId should be a preallocated 
		/// buffer to get the stream key. The buffer should have a length of 48.  length: 
		/// Length will return zero if the key could not be obtained. If the length 
		/// is greater than zero, it will be the length of the returned streaming id. 
		/// Retrieve the stream id after authorizing the shortcode. The authorization 
		/// window will expire in 5 minutes. Be sure to save the stream key before 
		/// the window expires. StreamGetStatus() should return the READY status to 
		/// use this method.
		/// </summary>
		public static void CoreStreamGetId(string shortcode, ref string streamId, out byte length)
		{
			string str_Shortcode = shortcode;
			IntPtr lp_Shortcode = GetAsciiIntPtr(str_Shortcode);
			string str_StreamId = streamId;
			IntPtr lp_StreamId = GetAsciiIntPtr(str_StreamId);
			PluginCoreStreamGetId(lp_Shortcode, lp_StreamId, out length);
			FreeIntPtr(lp_Shortcode);
			if (lp_StreamId != IntPtr.Zero)
			{
				streamId = Marshal.PtrToStringAnsi(lp_StreamId);
			}
			FreeIntPtr(lp_StreamId);
		}
		/// <summary>
		/// Intended for Cloud Gaming Platforms, store the streaming key to persist 
		/// in user preferences to continue streaming if the game is suspended or closed. 
		/// shortcode: The shortcode is a null terminated string. Use the shortcode 
		/// that authorized the stream to obtain the stream key.  If the status is 
		/// in the BROADCASTING or WATCHING state, passing a NULL shortcode will return 
		/// the active streamId.  streamKey should be a preallocated buffer to get 
		/// the stream key. The buffer should have a length of 48.  length: Length 
		/// will return zero if the key could not be obtained. If the length is greater 
		/// than zero, it will be the length of the returned streaming key.  Retrieve 
		/// the stream key after authorizing the shortcode. The authorization window 
		/// will expire in 5 minutes. Be sure to save the stream key before the window 
		/// expires.  StreamGetStatus() should return the READY status to use this 
		/// method.
		/// </summary>
		public static void CoreStreamGetKey(string shortcode, ref string streamKey, out byte length)
		{
			string str_Shortcode = shortcode;
			IntPtr lp_Shortcode = GetAsciiIntPtr(str_Shortcode);
			string str_StreamKey = streamKey;
			IntPtr lp_StreamKey = GetAsciiIntPtr(str_StreamKey);
			PluginCoreStreamGetKey(lp_Shortcode, lp_StreamKey, out length);
			FreeIntPtr(lp_Shortcode);
			if (lp_StreamKey != IntPtr.Zero)
			{
				streamKey = Marshal.PtrToStringAnsi(lp_StreamKey);
			}
			FreeIntPtr(lp_StreamKey);
		}
		/// <summary>
		/// Returns StreamStatus, the current status of the service
		/// </summary>
		public static ChromaSDK.Stream.StreamStatusType CoreStreamGetStatus()
		{
			ChromaSDK.Stream.StreamStatusType result = PluginCoreStreamGetStatus();
			return result;
		}
		/// <summary>
		/// Convert StreamStatusType to a printable string
		/// </summary>
		public static string CoreStreamGetStatusString(ChromaSDK.Stream.StreamStatusType status)
		{
			string result = Marshal.PtrToStringAnsi(PluginCoreStreamGetStatusString(status));
			return result;
		}
		/// <summary>
		/// This prevents the stream id and stream key from being obtained through the 
		/// shortcode. This closes the auth window.  shortcode is a null terminated 
		/// string.  StreamGetStatus() should return the READY status to use this method. 
		/// returns success when shortcode has been released
		/// </summary>
		public static bool CoreStreamReleaseShortcode(string shortcode)
		{
			string str_Shortcode = shortcode;
			IntPtr lp_Shortcode = GetAsciiIntPtr(str_Shortcode);
			bool result = PluginCoreStreamReleaseShortcode(lp_Shortcode);
			FreeIntPtr(lp_Shortcode);
			return result;
		}
		/// <summary>
		/// The focus is a null terminated string. Set the focus identifer for the application 
		/// designated to automatically change the streaming state.  Returns true on 
		/// success.
		/// </summary>
		public static bool CoreStreamSetFocus(string focus)
		{
			string str_Focus = focus;
			IntPtr lp_Focus = GetAsciiIntPtr(str_Focus);
			bool result = PluginCoreStreamSetFocus(lp_Focus);
			FreeIntPtr(lp_Focus);
			return result;
		}
		/// <summary>
		/// Returns true if the Chroma streaming is supported. If false is returned, 
		/// avoid calling stream methods.
		/// </summary>
		public static bool CoreStreamSupportsStreaming()
		{
			bool result = PluginCoreStreamSupportsStreaming();
			return result;
		}
		/// <summary>
		/// Begin watching the Chroma RGB data using streamID parameter.  streamId is 
		/// a null terminated string.  StreamGetStatus() should return the READY status 
		/// to use this method.
		/// </summary>
		public static bool CoreStreamWatch(string streamId, ulong timestamp)
		{
			string str_StreamId = streamId;
			IntPtr lp_StreamId = GetAsciiIntPtr(str_StreamId);
			bool result = PluginCoreStreamWatch(lp_StreamId, timestamp);
			FreeIntPtr(lp_StreamId);
			return result;
		}
		/// <summary>
		/// End watching Chroma RGB data stream.  StreamGetStatus() should return the 
		/// WATCHING status to use this method.
		/// </summary>
		public static bool CoreStreamWatchEnd()
		{
			bool result = PluginCoreStreamWatchEnd();
			return result;
		}
		/// <summary>
		/// Direct access to low level API.
		/// </summary>
		public static int CoreUnInit()
		{
			int result = PluginCoreUnInit();
			return result;
		}
		/// <summary>
		/// Creates a `Chroma` animation at the given path. The `deviceType` parameter 
		/// uses `EChromaSDKDeviceTypeEnum` as an integer. The `device` parameter uses 
		/// `EChromaSDKDevice1DEnum` or `EChromaSDKDevice2DEnum` as an integer, respective 
		/// to the `deviceType`. Returns the animation id upon success. Returns negative 
		/// one upon failure. Saves a `Chroma` animation file with the `.chroma` extension 
		/// at the given path. Returns the animation id upon success. Returns negative 
		/// one upon failure.
		/// </summary>
		public static int CreateAnimation(string path, int deviceType, int device)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			int result = PluginCreateAnimation(lp_Path, deviceType, device);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Creates a `Chroma` animation in memory without creating a file. The `deviceType` 
		/// parameter uses `EChromaSDKDeviceTypeEnum` as an integer. The `device` parameter 
		/// uses `EChromaSDKDevice1DEnum` or `EChromaSDKDevice2DEnum` as an integer, 
		/// respective to the `deviceType`. Returns the animation id upon success. 
		/// Returns negative one upon failure. Returns the animation id upon success. 
		/// Returns negative one upon failure.
		/// </summary>
		public static int CreateAnimationInMemory(int deviceType, int device)
		{
			int result = PluginCreateAnimationInMemory(deviceType, device);
			return result;
		}
		/// <summary>
		/// Create a device specific effect.
		/// </summary>
		public static int CreateEffect(Guid deviceId, EFFECT_TYPE effect, int[] colors, int size, out FChromaSDKGuid effectId)
		{
			int result = PluginCreateEffect(deviceId, (int)effect, colors, size, out effectId);
			return result;
		}
		/// <summary>
		/// Delete an effect given the effect id.
		/// </summary>
		public static int DeleteEffect(Guid effectId)
		{
			int result = PluginDeleteEffect(effectId);
			return result;
		}
		/// <summary>
		/// Duplicate the first animation frame so that the animation length matches 
		/// the frame count. Animation is referenced by id.
		/// </summary>
		public static void DuplicateFirstFrame(int animationId, int frameCount)
		{
			PluginDuplicateFirstFrame(animationId, frameCount);
		}
		/// <summary>
		/// Duplicate the first animation frame so that the animation length matches 
		/// the frame count. Animation is referenced by name.
		/// </summary>
		public static void DuplicateFirstFrameName(string path, int frameCount)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginDuplicateFirstFrameName(lp_Path, frameCount);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double DuplicateFirstFrameNameD(string path, double frameCount)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginDuplicateFirstFrameNameD(lp_Path, frameCount);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Duplicate all the frames of the animation to double the animation length. 
		/// Frame 1 becomes frame 1 and 2. Frame 2 becomes frame 3 and 4. And so on. 
		/// The animation is referenced by id.
		/// </summary>
		public static void DuplicateFrames(int animationId)
		{
			PluginDuplicateFrames(animationId);
		}
		/// <summary>
		/// Duplicate all the frames of the animation to double the animation length. 
		/// Frame 1 becomes frame 1 and 2. Frame 2 becomes frame 3 and 4. And so on. 
		/// The animation is referenced by name.
		/// </summary>
		public static void DuplicateFramesName(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginDuplicateFramesName(lp_Path);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double DuplicateFramesNameD(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginDuplicateFramesNameD(lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Duplicate all the animation frames in reverse so that the animation plays 
		/// forwards and backwards. Animation is referenced by id.
		/// </summary>
		public static void DuplicateMirrorFrames(int animationId)
		{
			PluginDuplicateMirrorFrames(animationId);
		}
		/// <summary>
		/// Duplicate all the animation frames in reverse so that the animation plays 
		/// forwards and backwards. Animation is referenced by name.
		/// </summary>
		public static void DuplicateMirrorFramesName(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginDuplicateMirrorFramesName(lp_Path);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double DuplicateMirrorFramesNameD(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginDuplicateMirrorFramesNameD(lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Fade the animation to black starting at the fade frame index to the end 
		/// of the animation. Animation is referenced by id.
		/// </summary>
		public static void FadeEndFrames(int animationId, int fade)
		{
			PluginFadeEndFrames(animationId, fade);
		}
		/// <summary>
		/// Fade the animation to black starting at the fade frame index to the end 
		/// of the animation. Animation is referenced by name.
		/// </summary>
		public static void FadeEndFramesName(string path, int fade)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginFadeEndFramesName(lp_Path, fade);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double FadeEndFramesNameD(string path, double fade)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginFadeEndFramesNameD(lp_Path, fade);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Fade the animation from black to full color starting at 0 to the fade frame 
		/// index. Animation is referenced by id.
		/// </summary>
		public static void FadeStartFrames(int animationId, int fade)
		{
			PluginFadeStartFrames(animationId, fade);
		}
		/// <summary>
		/// Fade the animation from black to full color starting at 0 to the fade frame 
		/// index. Animation is referenced by name.
		/// </summary>
		public static void FadeStartFramesName(string path, int fade)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginFadeStartFramesName(lp_Path, fade);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double FadeStartFramesNameD(string path, double fade)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginFadeStartFramesNameD(lp_Path, fade);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Set the RGB value for all colors in the specified frame. Animation is referenced 
		/// by id.
		/// </summary>
		public static void FillColor(int animationId, int frameId, int color)
		{
			PluginFillColor(animationId, frameId, color);
		}
		/// <summary>
		/// Set the RGB value for all colors for all frames. Animation is referenced 
		/// by id.
		/// </summary>
		public static void FillColorAllFrames(int animationId, int color)
		{
			PluginFillColorAllFrames(animationId, color);
		}
		/// <summary>
		/// Set the RGB value for all colors for all frames. Animation is referenced 
		/// by name.
		/// </summary>
		public static void FillColorAllFramesName(string path, int color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginFillColorAllFramesName(lp_Path, color);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double FillColorAllFramesNameD(string path, double color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginFillColorAllFramesNameD(lp_Path, color);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Set the RGB value for all colors for all frames. Use the range of 0 to 255 
		/// for red, green, and blue parameters. Animation is referenced by id.
		/// </summary>
		public static void FillColorAllFramesRGB(int animationId, int red, int green, int blue)
		{
			PluginFillColorAllFramesRGB(animationId, red, green, blue);
		}
		/// <summary>
		/// Set the RGB value for all colors for all frames. Use the range of 0 to 255 
		/// for red, green, and blue parameters. Animation is referenced by name.
		/// </summary>
		public static void FillColorAllFramesRGBName(string path, int red, int green, int blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginFillColorAllFramesRGBName(lp_Path, red, green, blue);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double FillColorAllFramesRGBNameD(string path, double red, double green, double blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginFillColorAllFramesRGBNameD(lp_Path, red, green, blue);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Set the RGB value for all colors in the specified frame. Animation is referenced 
		/// by name.
		/// </summary>
		public static void FillColorName(string path, int frameId, int color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginFillColorName(lp_Path, frameId, color);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double FillColorNameD(string path, double frameId, double color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginFillColorNameD(lp_Path, frameId, color);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Set the RGB value for all colors in the specified frame. Animation is referenced 
		/// by id.
		/// </summary>
		public static void FillColorRGB(int animationId, int frameId, int red, int green, int blue)
		{
			PluginFillColorRGB(animationId, frameId, red, green, blue);
		}
		/// <summary>
		/// Set the RGB value for all colors in the specified frame. Animation is referenced 
		/// by name.
		/// </summary>
		public static void FillColorRGBName(string path, int frameId, int red, int green, int blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginFillColorRGBName(lp_Path, frameId, red, green, blue);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double FillColorRGBNameD(string path, double frameId, double red, double green, double blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginFillColorRGBNameD(lp_Path, frameId, red, green, blue);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// This method will only update colors in the animation that are not already 
		/// set to black. Set the RGB value for a subset of colors in the specified 
		/// frame. Animation is referenced by id.
		/// </summary>
		public static void FillNonZeroColor(int animationId, int frameId, int color)
		{
			PluginFillNonZeroColor(animationId, frameId, color);
		}
		/// <summary>
		/// This method will only update colors in the animation that are not already 
		/// set to black. Set the RGB value for a subset of colors for all frames. 
		/// Animation is referenced by id.
		/// </summary>
		public static void FillNonZeroColorAllFrames(int animationId, int color)
		{
			PluginFillNonZeroColorAllFrames(animationId, color);
		}
		/// <summary>
		/// This method will only update colors in the animation that are not already 
		/// set to black. Set the RGB value for a subset of colors for all frames. 
		/// Animation is referenced by name.
		/// </summary>
		public static void FillNonZeroColorAllFramesName(string path, int color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginFillNonZeroColorAllFramesName(lp_Path, color);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double FillNonZeroColorAllFramesNameD(string path, double color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginFillNonZeroColorAllFramesNameD(lp_Path, color);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// This method will only update colors in the animation that are not already 
		/// set to black. Set the RGB value for a subset of colors for all frames. 
		/// Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		/// is referenced by id.
		/// </summary>
		public static void FillNonZeroColorAllFramesRGB(int animationId, int red, int green, int blue)
		{
			PluginFillNonZeroColorAllFramesRGB(animationId, red, green, blue);
		}
		/// <summary>
		/// This method will only update colors in the animation that are not already 
		/// set to black. Set the RGB value for a subset of colors for all frames. 
		/// Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		/// is referenced by name.
		/// </summary>
		public static void FillNonZeroColorAllFramesRGBName(string path, int red, int green, int blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginFillNonZeroColorAllFramesRGBName(lp_Path, red, green, blue);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double FillNonZeroColorAllFramesRGBNameD(string path, double red, double green, double blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginFillNonZeroColorAllFramesRGBNameD(lp_Path, red, green, blue);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// This method will only update colors in the animation that are not already 
		/// set to black. Set the RGB value for a subset of colors in the specified 
		/// frame. Animation is referenced by name.
		/// </summary>
		public static void FillNonZeroColorName(string path, int frameId, int color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginFillNonZeroColorName(lp_Path, frameId, color);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double FillNonZeroColorNameD(string path, double frameId, double color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginFillNonZeroColorNameD(lp_Path, frameId, color);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// This method will only update colors in the animation that are not already 
		/// set to black. Set the RGB value for a subset of colors in the specified 
		/// frame. Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		/// is referenced by id.
		/// </summary>
		public static void FillNonZeroColorRGB(int animationId, int frameId, int red, int green, int blue)
		{
			PluginFillNonZeroColorRGB(animationId, frameId, red, green, blue);
		}
		/// <summary>
		/// This method will only update colors in the animation that are not already 
		/// set to black. Set the RGB value for a subset of colors in the specified 
		/// frame. Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		/// is referenced by name.
		/// </summary>
		public static void FillNonZeroColorRGBName(string path, int frameId, int red, int green, int blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginFillNonZeroColorRGBName(lp_Path, frameId, red, green, blue);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double FillNonZeroColorRGBNameD(string path, double frameId, double red, double green, double blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginFillNonZeroColorRGBNameD(lp_Path, frameId, red, green, blue);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Fill the frame with random RGB values for the given frame. Animation is 
		/// referenced by id.
		/// </summary>
		public static void FillRandomColors(int animationId, int frameId)
		{
			PluginFillRandomColors(animationId, frameId);
		}
		/// <summary>
		/// Fill the frame with random RGB values for all frames. Animation is referenced 
		/// by id.
		/// </summary>
		public static void FillRandomColorsAllFrames(int animationId)
		{
			PluginFillRandomColorsAllFrames(animationId);
		}
		/// <summary>
		/// Fill the frame with random RGB values for all frames. Animation is referenced 
		/// by name.
		/// </summary>
		public static void FillRandomColorsAllFramesName(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginFillRandomColorsAllFramesName(lp_Path);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double FillRandomColorsAllFramesNameD(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginFillRandomColorsAllFramesNameD(lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Fill the frame with random black and white values for the specified frame. 
		/// Animation is referenced by id.
		/// </summary>
		public static void FillRandomColorsBlackAndWhite(int animationId, int frameId)
		{
			PluginFillRandomColorsBlackAndWhite(animationId, frameId);
		}
		/// <summary>
		/// Fill the frame with random black and white values for all frames. Animation 
		/// is referenced by id.
		/// </summary>
		public static void FillRandomColorsBlackAndWhiteAllFrames(int animationId)
		{
			PluginFillRandomColorsBlackAndWhiteAllFrames(animationId);
		}
		/// <summary>
		/// Fill the frame with random black and white values for all frames. Animation 
		/// is referenced by name.
		/// </summary>
		public static void FillRandomColorsBlackAndWhiteAllFramesName(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginFillRandomColorsBlackAndWhiteAllFramesName(lp_Path);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double FillRandomColorsBlackAndWhiteAllFramesNameD(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginFillRandomColorsBlackAndWhiteAllFramesNameD(lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Fill the frame with random black and white values for the specified frame. 
		/// Animation is referenced by name.
		/// </summary>
		public static void FillRandomColorsBlackAndWhiteName(string path, int frameId)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginFillRandomColorsBlackAndWhiteName(lp_Path, frameId);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double FillRandomColorsBlackAndWhiteNameD(string path, double frameId)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginFillRandomColorsBlackAndWhiteNameD(lp_Path, frameId);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Fill the frame with random RGB values for the given frame. Animation is 
		/// referenced by name.
		/// </summary>
		public static void FillRandomColorsName(string path, int frameId)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginFillRandomColorsName(lp_Path, frameId);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double FillRandomColorsNameD(string path, double frameId)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginFillRandomColorsNameD(lp_Path, frameId);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Fill the specified frame with RGB color where the animation color is less 
		/// than the RGB threshold. Animation is referenced by id.
		/// </summary>
		public static void FillThresholdColors(int animationId, int frameId, int threshold, int color)
		{
			PluginFillThresholdColors(animationId, frameId, threshold, color);
		}
		/// <summary>
		/// Fill all frames with RGB color where the animation color is less than the 
		/// RGB threshold. Animation is referenced by id.
		/// </summary>
		public static void FillThresholdColorsAllFrames(int animationId, int threshold, int color)
		{
			PluginFillThresholdColorsAllFrames(animationId, threshold, color);
		}
		/// <summary>
		/// Fill all frames with RGB color where the animation color is less than the 
		/// RGB threshold. Animation is referenced by name.
		/// </summary>
		public static void FillThresholdColorsAllFramesName(string path, int threshold, int color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginFillThresholdColorsAllFramesName(lp_Path, threshold, color);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double FillThresholdColorsAllFramesNameD(string path, double threshold, double color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginFillThresholdColorsAllFramesNameD(lp_Path, threshold, color);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Fill all frames with RGB color where the animation color is less than the 
		/// threshold. Animation is referenced by id.
		/// </summary>
		public static void FillThresholdColorsAllFramesRGB(int animationId, int threshold, int red, int green, int blue)
		{
			PluginFillThresholdColorsAllFramesRGB(animationId, threshold, red, green, blue);
		}
		/// <summary>
		/// Fill all frames with RGB color where the animation color is less than the 
		/// threshold. Animation is referenced by name.
		/// </summary>
		public static void FillThresholdColorsAllFramesRGBName(string path, int threshold, int red, int green, int blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginFillThresholdColorsAllFramesRGBName(lp_Path, threshold, red, green, blue);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double FillThresholdColorsAllFramesRGBNameD(string path, double threshold, double red, double green, double blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginFillThresholdColorsAllFramesRGBNameD(lp_Path, threshold, red, green, blue);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Fill all frames with the min RGB color where the animation color is less 
		/// than the min threshold AND with the max RGB color where the animation is 
		/// more than the max threshold. Animation is referenced by id.
		/// </summary>
		public static void FillThresholdColorsMinMaxAllFramesRGB(int animationId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue)
		{
			PluginFillThresholdColorsMinMaxAllFramesRGB(animationId, minThreshold, minRed, minGreen, minBlue, maxThreshold, maxRed, maxGreen, maxBlue);
		}
		/// <summary>
		/// Fill all frames with the min RGB color where the animation color is less 
		/// than the min threshold AND with the max RGB color where the animation is 
		/// more than the max threshold. Animation is referenced by name.
		/// </summary>
		public static void FillThresholdColorsMinMaxAllFramesRGBName(string path, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginFillThresholdColorsMinMaxAllFramesRGBName(lp_Path, minThreshold, minRed, minGreen, minBlue, maxThreshold, maxRed, maxGreen, maxBlue);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double FillThresholdColorsMinMaxAllFramesRGBNameD(string path, double minThreshold, double minRed, double minGreen, double minBlue, double maxThreshold, double maxRed, double maxGreen, double maxBlue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginFillThresholdColorsMinMaxAllFramesRGBNameD(lp_Path, minThreshold, minRed, minGreen, minBlue, maxThreshold, maxRed, maxGreen, maxBlue);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Fill the specified frame with the min RGB color where the animation color 
		/// is less than the min threshold AND with the max RGB color where the animation 
		/// is more than the max threshold. Animation is referenced by id.
		/// </summary>
		public static void FillThresholdColorsMinMaxRGB(int animationId, int frameId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue)
		{
			PluginFillThresholdColorsMinMaxRGB(animationId, frameId, minThreshold, minRed, minGreen, minBlue, maxThreshold, maxRed, maxGreen, maxBlue);
		}
		/// <summary>
		/// Fill the specified frame with the min RGB color where the animation color 
		/// is less than the min threshold AND with the max RGB color where the animation 
		/// is more than the max threshold. Animation is referenced by name.
		/// </summary>
		public static void FillThresholdColorsMinMaxRGBName(string path, int frameId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginFillThresholdColorsMinMaxRGBName(lp_Path, frameId, minThreshold, minRed, minGreen, minBlue, maxThreshold, maxRed, maxGreen, maxBlue);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double FillThresholdColorsMinMaxRGBNameD(string path, double frameId, double minThreshold, double minRed, double minGreen, double minBlue, double maxThreshold, double maxRed, double maxGreen, double maxBlue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginFillThresholdColorsMinMaxRGBNameD(lp_Path, frameId, minThreshold, minRed, minGreen, minBlue, maxThreshold, maxRed, maxGreen, maxBlue);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Fill the specified frame with RGB color where the animation color is less 
		/// than the RGB threshold. Animation is referenced by name.
		/// </summary>
		public static void FillThresholdColorsName(string path, int frameId, int threshold, int color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginFillThresholdColorsName(lp_Path, frameId, threshold, color);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double FillThresholdColorsNameD(string path, double frameId, double threshold, double color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginFillThresholdColorsNameD(lp_Path, frameId, threshold, color);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Fill the specified frame with RGB color where the animation color is less 
		/// than the RGB threshold. Animation is referenced by id.
		/// </summary>
		public static void FillThresholdColorsRGB(int animationId, int frameId, int threshold, int red, int green, int blue)
		{
			PluginFillThresholdColorsRGB(animationId, frameId, threshold, red, green, blue);
		}
		/// <summary>
		/// Fill the specified frame with RGB color where the animation color is less 
		/// than the RGB threshold. Animation is referenced by name.
		/// </summary>
		public static void FillThresholdColorsRGBName(string path, int frameId, int threshold, int red, int green, int blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginFillThresholdColorsRGBName(lp_Path, frameId, threshold, red, green, blue);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double FillThresholdColorsRGBNameD(string path, double frameId, double threshold, double red, double green, double blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginFillThresholdColorsRGBNameD(lp_Path, frameId, threshold, red, green, blue);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Fill all frames with RGB color where the animation color is less than the 
		/// RGB threshold. Animation is referenced by id.
		/// </summary>
		public static void FillThresholdRGBColorsAllFramesRGB(int animationId, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue)
		{
			PluginFillThresholdRGBColorsAllFramesRGB(animationId, redThreshold, greenThreshold, blueThreshold, red, green, blue);
		}
		/// <summary>
		/// Fill all frames with RGB color where the animation color is less than the 
		/// RGB threshold. Animation is referenced by name.
		/// </summary>
		public static void FillThresholdRGBColorsAllFramesRGBName(string path, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginFillThresholdRGBColorsAllFramesRGBName(lp_Path, redThreshold, greenThreshold, blueThreshold, red, green, blue);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double FillThresholdRGBColorsAllFramesRGBNameD(string path, double redThreshold, double greenThreshold, double blueThreshold, double red, double green, double blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginFillThresholdRGBColorsAllFramesRGBNameD(lp_Path, redThreshold, greenThreshold, blueThreshold, red, green, blue);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Fill the specified frame with RGB color where the animation color is less 
		/// than the RGB threshold. Animation is referenced by id.
		/// </summary>
		public static void FillThresholdRGBColorsRGB(int animationId, int frameId, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue)
		{
			PluginFillThresholdRGBColorsRGB(animationId, frameId, redThreshold, greenThreshold, blueThreshold, red, green, blue);
		}
		/// <summary>
		/// Fill the specified frame with RGB color where the animation color is less 
		/// than the RGB threshold. Animation is referenced by name.
		/// </summary>
		public static void FillThresholdRGBColorsRGBName(string path, int frameId, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginFillThresholdRGBColorsRGBName(lp_Path, frameId, redThreshold, greenThreshold, blueThreshold, red, green, blue);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double FillThresholdRGBColorsRGBNameD(string path, double frameId, double redThreshold, double greenThreshold, double blueThreshold, double red, double green, double blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginFillThresholdRGBColorsRGBNameD(lp_Path, frameId, redThreshold, greenThreshold, blueThreshold, red, green, blue);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Fill the specified frame with RGB color where the animation color is zero. 
		/// Animation is referenced by id.
		/// </summary>
		public static void FillZeroColor(int animationId, int frameId, int color)
		{
			PluginFillZeroColor(animationId, frameId, color);
		}
		/// <summary>
		/// Fill all frames with RGB color where the animation color is zero. Animation 
		/// is referenced by id.
		/// </summary>
		public static void FillZeroColorAllFrames(int animationId, int color)
		{
			PluginFillZeroColorAllFrames(animationId, color);
		}
		/// <summary>
		/// Fill all frames with RGB color where the animation color is zero. Animation 
		/// is referenced by name.
		/// </summary>
		public static void FillZeroColorAllFramesName(string path, int color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginFillZeroColorAllFramesName(lp_Path, color);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double FillZeroColorAllFramesNameD(string path, double color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginFillZeroColorAllFramesNameD(lp_Path, color);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Fill all frames with RGB color where the animation color is zero. Animation 
		/// is referenced by id.
		/// </summary>
		public static void FillZeroColorAllFramesRGB(int animationId, int red, int green, int blue)
		{
			PluginFillZeroColorAllFramesRGB(animationId, red, green, blue);
		}
		/// <summary>
		/// Fill all frames with RGB color where the animation color is zero. Animation 
		/// is referenced by name.
		/// </summary>
		public static void FillZeroColorAllFramesRGBName(string path, int red, int green, int blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginFillZeroColorAllFramesRGBName(lp_Path, red, green, blue);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double FillZeroColorAllFramesRGBNameD(string path, double red, double green, double blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginFillZeroColorAllFramesRGBNameD(lp_Path, red, green, blue);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Fill the specified frame with RGB color where the animation color is zero. 
		/// Animation is referenced by name.
		/// </summary>
		public static void FillZeroColorName(string path, int frameId, int color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginFillZeroColorName(lp_Path, frameId, color);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double FillZeroColorNameD(string path, double frameId, double color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginFillZeroColorNameD(lp_Path, frameId, color);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Fill the specified frame with RGB color where the animation color is zero. 
		/// Animation is referenced by id.
		/// </summary>
		public static void FillZeroColorRGB(int animationId, int frameId, int red, int green, int blue)
		{
			PluginFillZeroColorRGB(animationId, frameId, red, green, blue);
		}
		/// <summary>
		/// Fill the specified frame with RGB color where the animation color is zero. 
		/// Animation is referenced by name.
		/// </summary>
		public static void FillZeroColorRGBName(string path, int frameId, int red, int green, int blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginFillZeroColorRGBName(lp_Path, frameId, red, green, blue);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double FillZeroColorRGBNameD(string path, double frameId, double red, double green, double blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginFillZeroColorRGBNameD(lp_Path, frameId, red, green, blue);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Get the animation color for a frame given the `1D` `led`. The `led` should 
		/// be greater than or equal to 0 and less than the `MaxLeds`. Animation is 
		/// referenced by id.
		/// </summary>
		public static int Get1DColor(int animationId, int frameId, int led)
		{
			int result = PluginGet1DColor(animationId, frameId, led);
			return result;
		}
		/// <summary>
		/// Get the animation color for a frame given the `1D` `led`. The `led` should 
		/// be greater than or equal to 0 and less than the `MaxLeds`. Animation is 
		/// referenced by name.
		/// </summary>
		public static int Get1DColorName(string path, int frameId, int led)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			int result = PluginGet1DColorName(lp_Path, frameId, led);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double Get1DColorNameD(string path, double frameId, double led)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginGet1DColorNameD(lp_Path, frameId, led);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Get the animation color for a frame given the `2D` `row` and `column`. The 
		/// `row` should be greater than or equal to 0 and less than the `MaxRow`. 
		/// The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		/// Animation is referenced by id.
		/// </summary>
		public static int Get2DColor(int animationId, int frameId, int row, int column)
		{
			int result = PluginGet2DColor(animationId, frameId, row, column);
			return result;
		}
		/// <summary>
		/// Get the animation color for a frame given the `2D` `row` and `column`. The 
		/// `row` should be greater than or equal to 0 and less than the `MaxRow`. 
		/// The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		/// Animation is referenced by name.
		/// </summary>
		public static int Get2DColorName(string path, int frameId, int row, int column)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			int result = PluginGet2DColorName(lp_Path, frameId, row, column);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double Get2DColorNameD(string path, double frameId, double row, double column)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginGet2DColorNameD(lp_Path, frameId, row, column);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Get the animation id for the named animation.
		/// </summary>
		public static int GetAnimation(string name)
		{
			string str_Name = name;
			IntPtr lp_Name = GetPathIntPtr(str_Name);
			int result = PluginGetAnimation(lp_Name);
			FreeIntPtr(lp_Name);
			return result;
		}
		/// <summary>
		/// `PluginGetAnimationCount` will return the number of loaded animations.
		/// </summary>
		public static int GetAnimationCount()
		{
			int result = PluginGetAnimationCount();
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double GetAnimationD(string name)
		{
			string str_Name = name;
			IntPtr lp_Name = GetPathIntPtr(str_Name);
			double result = PluginGetAnimationD(lp_Name);
			FreeIntPtr(lp_Name);
			return result;
		}
		/// <summary>
		/// `PluginGetAnimationId` will return the `animationId` given the `index` of 
		/// the loaded animation. The `index` is zero-based and less than the number 
		/// returned by `PluginGetAnimationCount`. Use `PluginGetAnimationName` to 
		/// get the name of the animation.
		/// </summary>
		public static int GetAnimationId(int index)
		{
			int result = PluginGetAnimationId(index);
			return result;
		}
		/// <summary>
		/// `PluginGetAnimationName` takes an `animationId` and returns the name of 
		/// the animation of the `.chroma` animation file. If a name is not available 
		/// then an empty string will be returned.
		/// </summary>
		public static string GetAnimationName(int animationId)
		{
			string result = Marshal.PtrToStringAnsi(PluginGetAnimationName(animationId));
			return result;
		}
		/// <summary>
		/// Get the current frame of the animation referenced by id.
		/// </summary>
		public static int GetCurrentFrame(int animationId)
		{
			int result = PluginGetCurrentFrame(animationId);
			return result;
		}
		/// <summary>
		/// Get the current frame of the animation referenced by name.
		/// </summary>
		public static int GetCurrentFrameName(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			int result = PluginGetCurrentFrameName(lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double GetCurrentFrameNameD(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginGetCurrentFrameNameD(lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Returns the `EChromaSDKDevice1DEnum` or `EChromaSDKDevice2DEnum` of a `Chroma` 
		/// animation respective to the `deviceType`, as an integer upon success. Returns 
		/// negative one upon failure.
		/// </summary>
		public static int GetDevice(int animationId)
		{
			int result = PluginGetDevice(animationId);
			return result;
		}
		/// <summary>
		/// Returns the `EChromaSDKDevice1DEnum` or `EChromaSDKDevice2DEnum` of a `Chroma` 
		/// animation respective to the `deviceType`, as an integer upon success. Returns 
		/// negative one upon failure.
		/// </summary>
		public static int GetDeviceName(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			int result = PluginGetDeviceName(lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double GetDeviceNameD(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginGetDeviceNameD(lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Returns the `EChromaSDKDeviceTypeEnum` of a `Chroma` animation as an integer 
		/// upon success. Returns negative one upon failure.
		/// </summary>
		public static int GetDeviceType(int animationId)
		{
			int result = PluginGetDeviceType(animationId);
			return result;
		}
		/// <summary>
		/// Returns the `EChromaSDKDeviceTypeEnum` of a `Chroma` animation as an integer 
		/// upon success. Returns negative one upon failure.
		/// </summary>
		public static int GetDeviceTypeName(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			int result = PluginGetDeviceTypeName(lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double GetDeviceTypeNameD(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginGetDeviceTypeNameD(lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Gets the frame colors and duration (in seconds) for a `Chroma` animation. 
		/// The `color` is expected to be an array of the expected dimensions for the 
		/// `deviceType/device`. The `length` parameter is the size of the `color` 
		/// array. For `EChromaSDKDevice1DEnum` the array size should be `MAX LEDS`. 
		/// For `EChromaSDKDevice2DEnum` the array size should be `MAX ROW` * `MAX 
		/// COLUMN`. Returns the animation id upon success. Returns negative one upon 
		/// failure.
		/// </summary>
		public static int GetFrame(int animationId, int frameIndex, out float duration, int[] colors, int length)
		{
			int result = PluginGetFrame(animationId, frameIndex, out duration, colors, length);
			return result;
		}
		/// <summary>
		/// Returns the frame count of a `Chroma` animation upon success. Returns negative 
		/// one upon failure.
		/// </summary>
		public static int GetFrameCount(int animationId)
		{
			int result = PluginGetFrameCount(animationId);
			return result;
		}
		/// <summary>
		/// Returns the frame count of a `Chroma` animation upon success. Returns negative 
		/// one upon failure.
		/// </summary>
		public static int GetFrameCountName(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			int result = PluginGetFrameCountName(lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double GetFrameCountNameD(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginGetFrameCountNameD(lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Get the color of an animation key for the given frame referenced by id. 
		///
		/// </summary>
		public static int GetKeyColor(int animationId, int frameId, int rzkey)
		{
			int result = PluginGetKeyColor(animationId, frameId, rzkey);
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double GetKeyColorD(string path, double frameId, double rzkey)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginGetKeyColorD(lp_Path, frameId, rzkey);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Get the color of an animation key for the given frame referenced by name. 
		///
		/// </summary>
		public static int GetKeyColorName(string path, int frameId, int rzkey)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			int result = PluginGetKeyColorName(lp_Path, frameId, rzkey);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Returns `RZRESULT_SUCCESS` if the plugin has been initialized successfully. 
		/// Returns `RZRESULT_DLL_NOT_FOUND` if core Chroma library is not found. Returns 
		/// `RZRESULT_DLL_INVALID_SIGNATURE` if core Chroma library has an invalid 
		/// signature.
		/// </summary>
		public static int GetLibraryLoadedState()
		{
			int result = PluginGetLibraryLoadedState();
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double GetLibraryLoadedStateD()
		{
			double result = PluginGetLibraryLoadedStateD();
			return result;
		}
		/// <summary>
		/// Returns the `MAX COLUMN` given the `EChromaSDKDevice2DEnum` device as an 
		/// integer upon success. Returns negative one upon failure.
		/// </summary>
		public static int GetMaxColumn(Device2D device)
		{
			int result = PluginGetMaxColumn((int)device);
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double GetMaxColumnD(double device)
		{
			double result = PluginGetMaxColumnD(device);
			return result;
		}
		/// <summary>
		/// Returns the MAX LEDS given the `EChromaSDKDevice1DEnum` device as an integer 
		/// upon success. Returns negative one upon failure.
		/// </summary>
		public static int GetMaxLeds(Device1D device)
		{
			int result = PluginGetMaxLeds((int)device);
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double GetMaxLedsD(double device)
		{
			double result = PluginGetMaxLedsD(device);
			return result;
		}
		/// <summary>
		/// Returns the `MAX ROW` given the `EChromaSDKDevice2DEnum` device as an integer 
		/// upon success. Returns negative one upon failure.
		/// </summary>
		public static int GetMaxRow(Device2D device)
		{
			int result = PluginGetMaxRow((int)device);
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double GetMaxRowD(double device)
		{
			double result = PluginGetMaxRowD(device);
			return result;
		}
		/// <summary>
		/// `PluginGetPlayingAnimationCount` will return the number of playing animations. 
		///
		/// </summary>
		public static int GetPlayingAnimationCount()
		{
			int result = PluginGetPlayingAnimationCount();
			return result;
		}
		/// <summary>
		/// `PluginGetPlayingAnimationId` will return the `animationId` given the `index` 
		/// of the playing animation. The `index` is zero-based and less than the number 
		/// returned by `PluginGetPlayingAnimationCount`. Use `PluginGetAnimationName` 
		/// to get the name of the animation.
		/// </summary>
		public static int GetPlayingAnimationId(int index)
		{
			int result = PluginGetPlayingAnimationId(index);
			return result;
		}
		/// <summary>
		/// Get the RGB color given red, green, and blue.
		/// </summary>
		public static int GetRGB(int red, int green, int blue)
		{
			int result = PluginGetRGB(red, green, blue);
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double GetRGBD(double red, double green, double blue)
		{
			double result = PluginGetRGBD(red, green, blue);
			return result;
		}
		/// <summary>
		/// Check if the animation has loop enabled referenced by id.
		/// </summary>
		public static bool HasAnimationLoop(int animationId)
		{
			bool result = PluginHasAnimationLoop(animationId);
			return result;
		}
		/// <summary>
		/// Check if the animation has loop enabled referenced by name.
		/// </summary>
		public static bool HasAnimationLoopName(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			bool result = PluginHasAnimationLoopName(lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double HasAnimationLoopNameD(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginHasAnimationLoopNameD(lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Initialize the ChromaSDK. Zero indicates  success, otherwise failure. Many 
		/// API methods auto initialize the ChromaSDK if not already initialized.
		/// </summary>
		public static int Init()
		{
			int result = PluginInit();
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double InitD()
		{
			double result = PluginInitD();
			return result;
		}
		/// <summary>
		/// Initialize the ChromaSDK. AppInfo populates the details in Synapse. Zero 
		/// indicates  success, otherwise failure. Many API methods auto initialize 
		/// the ChromaSDK if not already initialized.
		/// </summary>
		public static int InitSDK(ref ChromaSDK.APPINFOTYPE appInfo)
		{
			int result = PluginInitSDK(ref appInfo);
			return result;
		}
		/// <summary>
		/// Insert an animation delay by duplicating the frame by the delay number of 
		/// times. Animation is referenced by id.
		/// </summary>
		public static void InsertDelay(int animationId, int frameId, int delay)
		{
			PluginInsertDelay(animationId, frameId, delay);
		}
		/// <summary>
		/// Insert an animation delay by duplicating the frame by the delay number of 
		/// times. Animation is referenced by name.
		/// </summary>
		public static void InsertDelayName(string path, int frameId, int delay)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginInsertDelayName(lp_Path, frameId, delay);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double InsertDelayNameD(string path, double frameId, double delay)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginInsertDelayNameD(lp_Path, frameId, delay);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Duplicate the source frame index at the target frame index. Animation is 
		/// referenced by id.
		/// </summary>
		public static void InsertFrame(int animationId, int sourceFrame, int targetFrame)
		{
			PluginInsertFrame(animationId, sourceFrame, targetFrame);
		}
		/// <summary>
		/// Duplicate the source frame index at the target frame index. Animation is 
		/// referenced by name.
		/// </summary>
		public static void InsertFrameName(string path, int sourceFrame, int targetFrame)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginInsertFrameName(lp_Path, sourceFrame, targetFrame);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double InsertFrameNameD(string path, double sourceFrame, double targetFrame)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginInsertFrameNameD(lp_Path, sourceFrame, targetFrame);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Invert all the colors at the specified frame. Animation is referenced by 
		/// id.
		/// </summary>
		public static void InvertColors(int animationId, int frameId)
		{
			PluginInvertColors(animationId, frameId);
		}
		/// <summary>
		/// Invert all the colors for all frames. Animation is referenced by id.
		/// </summary>
		public static void InvertColorsAllFrames(int animationId)
		{
			PluginInvertColorsAllFrames(animationId);
		}
		/// <summary>
		/// Invert all the colors for all frames. Animation is referenced by name.
		/// </summary>
		public static void InvertColorsAllFramesName(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginInvertColorsAllFramesName(lp_Path);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double InvertColorsAllFramesNameD(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginInvertColorsAllFramesNameD(lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Invert all the colors at the specified frame. Animation is referenced by 
		/// name.
		/// </summary>
		public static void InvertColorsName(string path, int frameId)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginInvertColorsName(lp_Path, frameId);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double InvertColorsNameD(string path, double frameId)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginInvertColorsNameD(lp_Path, frameId);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Check if the animation is paused referenced by id.
		/// </summary>
		public static bool IsAnimationPaused(int animationId)
		{
			bool result = PluginIsAnimationPaused(animationId);
			return result;
		}
		/// <summary>
		/// Check if the animation is paused referenced by name.
		/// </summary>
		public static bool IsAnimationPausedName(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			bool result = PluginIsAnimationPausedName(lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double IsAnimationPausedNameD(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginIsAnimationPausedNameD(lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// The editor dialog is a non-blocking modal window, this method returns true 
		/// if the modal window is open, otherwise false.
		/// </summary>
		public static bool IsDialogOpen()
		{
			bool result = PluginIsDialogOpen();
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double IsDialogOpenD()
		{
			double result = PluginIsDialogOpenD();
			return result;
		}
		/// <summary>
		/// Returns true if the plugin has been initialized. Returns false if the plugin 
		/// is uninitialized.
		/// </summary>
		public static bool IsInitialized()
		{
			bool result = PluginIsInitialized();
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double IsInitializedD()
		{
			double result = PluginIsInitializedD();
			return result;
		}
		/// <summary>
		/// If the method can be invoked the method returns true.
		/// </summary>
		public static bool IsPlatformSupported()
		{
			bool result = PluginIsPlatformSupported();
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double IsPlatformSupportedD()
		{
			double result = PluginIsPlatformSupportedD();
			return result;
		}
		/// <summary>
		/// `PluginIsPlayingName` automatically handles initializing the `ChromaSDK`. 
		/// The named `.chroma` animation file will be automatically opened. The method 
		/// will return whether the animation is playing or not. Animation is referenced 
		/// by id.
		/// </summary>
		public static bool IsPlaying(int animationId)
		{
			bool result = PluginIsPlaying(animationId);
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double IsPlayingD(double animationId)
		{
			double result = PluginIsPlayingD(animationId);
			return result;
		}
		/// <summary>
		/// `PluginIsPlayingName` automatically handles initializing the `ChromaSDK`. 
		/// The named `.chroma` animation file will be automatically opened. The method 
		/// will return whether the animation is playing or not. Animation is referenced 
		/// by name.
		/// </summary>
		public static bool IsPlayingName(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			bool result = PluginIsPlayingName(lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double IsPlayingNameD(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginIsPlayingNameD(lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// `PluginIsPlayingType` automatically handles initializing the `ChromaSDK`. 
		/// If any animation is playing for the `deviceType` and `device` combination, 
		/// the method will return true, otherwise false.
		/// </summary>
		public static bool IsPlayingType(int deviceType, int device)
		{
			bool result = PluginIsPlayingType(deviceType, device);
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double IsPlayingTypeD(double deviceType, double device)
		{
			double result = PluginIsPlayingTypeD(deviceType, device);
			return result;
		}
		/// <summary>
		/// Do a lerp math operation on a float.
		/// </summary>
		public static float Lerp(float start, float end, float amt)
		{
			float result = PluginLerp(start, end, amt);
			return result;
		}
		/// <summary>
		/// Lerp from one color to another given t in the range 0.0 to 1.0.
		/// </summary>
		public static int LerpColor(int from, int to, float t)
		{
			int result = PluginLerpColor(from, to, t);
			return result;
		}
		/// <summary>
		/// Loads `Chroma` effects so that the animation can be played immediately. 
		/// Returns the animation id upon success. Returns negative one upon failure. 
		///
		/// </summary>
		public static int LoadAnimation(int animationId)
		{
			int result = PluginLoadAnimation(animationId);
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double LoadAnimationD(double animationId)
		{
			double result = PluginLoadAnimationD(animationId);
			return result;
		}
		/// <summary>
		/// Load the named animation.
		/// </summary>
		public static void LoadAnimationName(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginLoadAnimationName(lp_Path);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// Load a composite set of animations.
		/// </summary>
		public static void LoadComposite(string name)
		{
			string str_Name = name;
			IntPtr lp_Name = GetPathIntPtr(str_Name);
			PluginLoadComposite(lp_Name);
			FreeIntPtr(lp_Name);
		}
		/// <summary>
		/// Make a blank animation for the length of the frame count. Frame duration 
		/// defaults to the duration. The frame color defaults to color. Animation 
		/// is referenced by id.
		/// </summary>
		public static void MakeBlankFrames(int animationId, int frameCount, float duration, int color)
		{
			PluginMakeBlankFrames(animationId, frameCount, duration, color);
		}
		/// <summary>
		/// Make a blank animation for the length of the frame count. Frame duration 
		/// defaults to the duration. The frame color defaults to color. Animation 
		/// is referenced by name.
		/// </summary>
		public static void MakeBlankFramesName(string path, int frameCount, float duration, int color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginMakeBlankFramesName(lp_Path, frameCount, duration, color);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double MakeBlankFramesNameD(string path, double frameCount, double duration, double color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginMakeBlankFramesNameD(lp_Path, frameCount, duration, color);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Make a blank animation for the length of the frame count. Frame duration 
		/// defaults to the duration. The frame color is random. Animation is referenced 
		/// by id.
		/// </summary>
		public static void MakeBlankFramesRandom(int animationId, int frameCount, float duration)
		{
			PluginMakeBlankFramesRandom(animationId, frameCount, duration);
		}
		/// <summary>
		/// Make a blank animation for the length of the frame count. Frame duration 
		/// defaults to the duration. The frame color is random black and white. Animation 
		/// is referenced by id.
		/// </summary>
		public static void MakeBlankFramesRandomBlackAndWhite(int animationId, int frameCount, float duration)
		{
			PluginMakeBlankFramesRandomBlackAndWhite(animationId, frameCount, duration);
		}
		/// <summary>
		/// Make a blank animation for the length of the frame count. Frame duration 
		/// defaults to the duration. The frame color is random black and white. Animation 
		/// is referenced by name.
		/// </summary>
		public static void MakeBlankFramesRandomBlackAndWhiteName(string path, int frameCount, float duration)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginMakeBlankFramesRandomBlackAndWhiteName(lp_Path, frameCount, duration);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double MakeBlankFramesRandomBlackAndWhiteNameD(string path, double frameCount, double duration)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginMakeBlankFramesRandomBlackAndWhiteNameD(lp_Path, frameCount, duration);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Make a blank animation for the length of the frame count. Frame duration 
		/// defaults to the duration. The frame color is random. Animation is referenced 
		/// by name.
		/// </summary>
		public static void MakeBlankFramesRandomName(string path, int frameCount, float duration)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginMakeBlankFramesRandomName(lp_Path, frameCount, duration);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double MakeBlankFramesRandomNameD(string path, double frameCount, double duration)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginMakeBlankFramesRandomNameD(lp_Path, frameCount, duration);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Make a blank animation for the length of the frame count. Frame duration 
		/// defaults to the duration. The frame color defaults to color. Animation 
		/// is referenced by id.
		/// </summary>
		public static void MakeBlankFramesRGB(int animationId, int frameCount, float duration, int red, int green, int blue)
		{
			PluginMakeBlankFramesRGB(animationId, frameCount, duration, red, green, blue);
		}
		/// <summary>
		/// Make a blank animation for the length of the frame count. Frame duration 
		/// defaults to the duration. The frame color defaults to color. Animation 
		/// is referenced by name.
		/// </summary>
		public static void MakeBlankFramesRGBName(string path, int frameCount, float duration, int red, int green, int blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginMakeBlankFramesRGBName(lp_Path, frameCount, duration, red, green, blue);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double MakeBlankFramesRGBNameD(string path, double frameCount, double duration, double red, double green, double blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginMakeBlankFramesRGBNameD(lp_Path, frameCount, duration, red, green, blue);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Flips the color grid horizontally for all `Chroma` animation frames. Returns 
		/// the animation id upon success. Returns negative one upon failure.
		/// </summary>
		public static int MirrorHorizontally(int animationId)
		{
			int result = PluginMirrorHorizontally(animationId);
			return result;
		}
		/// <summary>
		/// Flips the color grid vertically for all `Chroma` animation frames. This 
		/// method has no effect for `EChromaSDKDevice1DEnum` devices. Returns the 
		/// animation id upon success. Returns negative one upon failure.
		/// </summary>
		public static int MirrorVertically(int animationId)
		{
			int result = PluginMirrorVertically(animationId);
			return result;
		}
		/// <summary>
		/// Multiply the color intensity with the lerp result from color 1 to color 
		/// 2 using the frame index divided by the frame count for the `t` parameter. 
		/// Animation is referenced in id.
		/// </summary>
		public static void MultiplyColorLerpAllFrames(int animationId, int color1, int color2)
		{
			PluginMultiplyColorLerpAllFrames(animationId, color1, color2);
		}
		/// <summary>
		/// Multiply the color intensity with the lerp result from color 1 to color 
		/// 2 using the frame index divided by the frame count for the `t` parameter. 
		/// Animation is referenced in name.
		/// </summary>
		public static void MultiplyColorLerpAllFramesName(string path, int color1, int color2)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginMultiplyColorLerpAllFramesName(lp_Path, color1, color2);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double MultiplyColorLerpAllFramesNameD(string path, double color1, double color2)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginMultiplyColorLerpAllFramesNameD(lp_Path, color1, color2);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Multiply all the colors in the frame by the intensity value. The valid the 
		/// intensity range is from 0.0 to 255.0. RGB components are multiplied equally. 
		/// An intensity of 0.5 would half the color value. Black colors in the frame 
		/// will not be affected by this method.
		/// </summary>
		public static void MultiplyIntensity(int animationId, int frameId, float intensity)
		{
			PluginMultiplyIntensity(animationId, frameId, intensity);
		}
		/// <summary>
		/// Multiply all the colors for all frames by the intensity value. The valid 
		/// the intensity range is from 0.0 to 255.0. RGB components are multiplied 
		/// equally. An intensity of 0.5 would half the color value. Black colors in 
		/// the frame will not be affected by this method.
		/// </summary>
		public static void MultiplyIntensityAllFrames(int animationId, float intensity)
		{
			PluginMultiplyIntensityAllFrames(animationId, intensity);
		}
		/// <summary>
		/// Multiply all the colors for all frames by the intensity value. The valid 
		/// the intensity range is from 0.0 to 255.0. RGB components are multiplied 
		/// equally. An intensity of 0.5 would half the color value. Black colors in 
		/// the frame will not be affected by this method.
		/// </summary>
		public static void MultiplyIntensityAllFramesName(string path, float intensity)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginMultiplyIntensityAllFramesName(lp_Path, intensity);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double MultiplyIntensityAllFramesNameD(string path, double intensity)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginMultiplyIntensityAllFramesNameD(lp_Path, intensity);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Multiply all frames by the RBG color intensity. Animation is referenced 
		/// by id.
		/// </summary>
		public static void MultiplyIntensityAllFramesRGB(int animationId, int red, int green, int blue)
		{
			PluginMultiplyIntensityAllFramesRGB(animationId, red, green, blue);
		}
		/// <summary>
		/// Multiply all frames by the RBG color intensity. Animation is referenced 
		/// by name.
		/// </summary>
		public static void MultiplyIntensityAllFramesRGBName(string path, int red, int green, int blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginMultiplyIntensityAllFramesRGBName(lp_Path, red, green, blue);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double MultiplyIntensityAllFramesRGBNameD(string path, double red, double green, double blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginMultiplyIntensityAllFramesRGBNameD(lp_Path, red, green, blue);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Multiply the specific frame by the RBG color intensity. Animation is referenced 
		/// by id.
		/// </summary>
		public static void MultiplyIntensityColor(int animationId, int frameId, int color)
		{
			PluginMultiplyIntensityColor(animationId, frameId, color);
		}
		/// <summary>
		/// Multiply all frames by the RBG color intensity. Animation is referenced 
		/// by id.
		/// </summary>
		public static void MultiplyIntensityColorAllFrames(int animationId, int color)
		{
			PluginMultiplyIntensityColorAllFrames(animationId, color);
		}
		/// <summary>
		/// Multiply all frames by the RBG color intensity. Animation is referenced 
		/// by name.
		/// </summary>
		public static void MultiplyIntensityColorAllFramesName(string path, int color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginMultiplyIntensityColorAllFramesName(lp_Path, color);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double MultiplyIntensityColorAllFramesNameD(string path, double color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginMultiplyIntensityColorAllFramesNameD(lp_Path, color);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Multiply the specific frame by the RBG color intensity. Animation is referenced 
		/// by name.
		/// </summary>
		public static void MultiplyIntensityColorName(string path, int frameId, int color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginMultiplyIntensityColorName(lp_Path, frameId, color);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double MultiplyIntensityColorNameD(string path, double frameId, double color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginMultiplyIntensityColorNameD(lp_Path, frameId, color);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Multiply all the colors in the frame by the intensity value. The valid the 
		/// intensity range is from 0.0 to 255.0. RGB components are multiplied equally. 
		/// An intensity of 0.5 would half the color value. Black colors in the frame 
		/// will not be affected by this method.
		/// </summary>
		public static void MultiplyIntensityName(string path, int frameId, float intensity)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginMultiplyIntensityName(lp_Path, frameId, intensity);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double MultiplyIntensityNameD(string path, double frameId, double intensity)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginMultiplyIntensityNameD(lp_Path, frameId, intensity);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Multiply the specific frame by the RBG color intensity. Animation is referenced 
		/// by id.
		/// </summary>
		public static void MultiplyIntensityRGB(int animationId, int frameId, int red, int green, int blue)
		{
			PluginMultiplyIntensityRGB(animationId, frameId, red, green, blue);
		}
		/// <summary>
		/// Multiply the specific frame by the RBG color intensity. Animation is referenced 
		/// by name.
		/// </summary>
		public static void MultiplyIntensityRGBName(string path, int frameId, int red, int green, int blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginMultiplyIntensityRGBName(lp_Path, frameId, red, green, blue);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double MultiplyIntensityRGBNameD(string path, double frameId, double red, double green, double blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginMultiplyIntensityRGBNameD(lp_Path, frameId, red, green, blue);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Multiply the specific frame by the color lerp result between color 1 and 
		/// 2 using the frame color value as the `t` value. Animation is referenced 
		/// by id.
		/// </summary>
		public static void MultiplyNonZeroTargetColorLerp(int animationId, int frameId, int color1, int color2)
		{
			PluginMultiplyNonZeroTargetColorLerp(animationId, frameId, color1, color2);
		}
		/// <summary>
		/// Multiply all frames by the color lerp result between color 1 and 2 using 
		/// the frame color value as the `t` value. Animation is referenced by id. 
		///
		/// </summary>
		public static void MultiplyNonZeroTargetColorLerpAllFrames(int animationId, int color1, int color2)
		{
			PluginMultiplyNonZeroTargetColorLerpAllFrames(animationId, color1, color2);
		}
		/// <summary>
		/// Multiply all frames by the color lerp result between color 1 and 2 using 
		/// the frame color value as the `t` value. Animation is referenced by name. 
		///
		/// </summary>
		public static void MultiplyNonZeroTargetColorLerpAllFramesName(string path, int color1, int color2)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginMultiplyNonZeroTargetColorLerpAllFramesName(lp_Path, color1, color2);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double MultiplyNonZeroTargetColorLerpAllFramesNameD(string path, double color1, double color2)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginMultiplyNonZeroTargetColorLerpAllFramesNameD(lp_Path, color1, color2);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Multiply the specific frame by the color lerp result between RGB 1 and 2 
		/// using the frame color value as the `t` value. Animation is referenced by 
		/// id.
		/// </summary>
		public static void MultiplyNonZeroTargetColorLerpAllFramesRGB(int animationId, int red1, int green1, int blue1, int red2, int green2, int blue2)
		{
			PluginMultiplyNonZeroTargetColorLerpAllFramesRGB(animationId, red1, green1, blue1, red2, green2, blue2);
		}
		/// <summary>
		/// Multiply the specific frame by the color lerp result between RGB 1 and 2 
		/// using the frame color value as the `t` value. Animation is referenced by 
		/// name.
		/// </summary>
		public static void MultiplyNonZeroTargetColorLerpAllFramesRGBName(string path, int red1, int green1, int blue1, int red2, int green2, int blue2)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginMultiplyNonZeroTargetColorLerpAllFramesRGBName(lp_Path, red1, green1, blue1, red2, green2, blue2);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double MultiplyNonZeroTargetColorLerpAllFramesRGBNameD(string path, double red1, double green1, double blue1, double red2, double green2, double blue2)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginMultiplyNonZeroTargetColorLerpAllFramesRGBNameD(lp_Path, red1, green1, blue1, red2, green2, blue2);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Multiply the specific frame by the color lerp result between color 1 and 
		/// 2 using the frame color value as the `t` value. Animation is referenced 
		/// by id.
		/// </summary>
		public static void MultiplyTargetColorLerp(int animationId, int frameId, int color1, int color2)
		{
			PluginMultiplyTargetColorLerp(animationId, frameId, color1, color2);
		}
		/// <summary>
		/// Multiply all frames by the color lerp result between color 1 and 2 using 
		/// the frame color value as the `t` value. Animation is referenced by id. 
		///
		/// </summary>
		public static void MultiplyTargetColorLerpAllFrames(int animationId, int color1, int color2)
		{
			PluginMultiplyTargetColorLerpAllFrames(animationId, color1, color2);
		}
		/// <summary>
		/// Multiply all frames by the color lerp result between color 1 and 2 using 
		/// the frame color value as the `t` value. Animation is referenced by name. 
		///
		/// </summary>
		public static void MultiplyTargetColorLerpAllFramesName(string path, int color1, int color2)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginMultiplyTargetColorLerpAllFramesName(lp_Path, color1, color2);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double MultiplyTargetColorLerpAllFramesNameD(string path, double color1, double color2)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginMultiplyTargetColorLerpAllFramesNameD(lp_Path, color1, color2);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Multiply all frames by the color lerp result between RGB 1 and 2 using the 
		/// frame color value as the `t` value. Animation is referenced by id.
		/// </summary>
		public static void MultiplyTargetColorLerpAllFramesRGB(int animationId, int red1, int green1, int blue1, int red2, int green2, int blue2)
		{
			PluginMultiplyTargetColorLerpAllFramesRGB(animationId, red1, green1, blue1, red2, green2, blue2);
		}
		/// <summary>
		/// Multiply all frames by the color lerp result between RGB 1 and 2 using the 
		/// frame color value as the `t` value. Animation is referenced by name.
		/// </summary>
		public static void MultiplyTargetColorLerpAllFramesRGBName(string path, int red1, int green1, int blue1, int red2, int green2, int blue2)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginMultiplyTargetColorLerpAllFramesRGBName(lp_Path, red1, green1, blue1, red2, green2, blue2);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double MultiplyTargetColorLerpAllFramesRGBNameD(string path, double red1, double green1, double blue1, double red2, double green2, double blue2)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginMultiplyTargetColorLerpAllFramesRGBNameD(lp_Path, red1, green1, blue1, red2, green2, blue2);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Multiply the specific frame by the color lerp result between color 1 and 
		/// 2 using the frame color value as the `t` value. Animation is referenced 
		/// by name.
		/// </summary>
		public static void MultiplyTargetColorLerpName(string path, int frameId, int color1, int color2)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginMultiplyTargetColorLerpName(lp_Path, frameId, color1, color2);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// Offset all colors in the frame using the RGB offset. Use the range of -255 
		/// to 255 for red, green, and blue parameters. Negative values remove color. 
		/// Positive values add color.
		/// </summary>
		public static void OffsetColors(int animationId, int frameId, int red, int green, int blue)
		{
			PluginOffsetColors(animationId, frameId, red, green, blue);
		}
		/// <summary>
		/// Offset all colors for all frames using the RGB offset. Use the range of 
		/// -255 to 255 for red, green, and blue parameters. Negative values remove 
		/// color. Positive values add color.
		/// </summary>
		public static void OffsetColorsAllFrames(int animationId, int red, int green, int blue)
		{
			PluginOffsetColorsAllFrames(animationId, red, green, blue);
		}
		/// <summary>
		/// Offset all colors for all frames using the RGB offset. Use the range of 
		/// -255 to 255 for red, green, and blue parameters. Negative values remove 
		/// color. Positive values add color.
		/// </summary>
		public static void OffsetColorsAllFramesName(string path, int red, int green, int blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginOffsetColorsAllFramesName(lp_Path, red, green, blue);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double OffsetColorsAllFramesNameD(string path, double red, double green, double blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginOffsetColorsAllFramesNameD(lp_Path, red, green, blue);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Offset all colors in the frame using the RGB offset. Use the range of -255 
		/// to 255 for red, green, and blue parameters. Negative values remove color. 
		/// Positive values add color.
		/// </summary>
		public static void OffsetColorsName(string path, int frameId, int red, int green, int blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginOffsetColorsName(lp_Path, frameId, red, green, blue);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double OffsetColorsNameD(string path, double frameId, double red, double green, double blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginOffsetColorsNameD(lp_Path, frameId, red, green, blue);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// This method will only update colors in the animation that are not already 
		/// set to black. Offset a subset of colors in the frame using the RGB offset. 
		/// Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		/// values remove color. Positive values add color.
		/// </summary>
		public static void OffsetNonZeroColors(int animationId, int frameId, int red, int green, int blue)
		{
			PluginOffsetNonZeroColors(animationId, frameId, red, green, blue);
		}
		/// <summary>
		/// This method will only update colors in the animation that are not already 
		/// set to black. Offset a subset of colors for all frames using the RGB offset. 
		/// Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		/// values remove color. Positive values add color.
		/// </summary>
		public static void OffsetNonZeroColorsAllFrames(int animationId, int red, int green, int blue)
		{
			PluginOffsetNonZeroColorsAllFrames(animationId, red, green, blue);
		}
		/// <summary>
		/// This method will only update colors in the animation that are not already 
		/// set to black. Offset a subset of colors for all frames using the RGB offset. 
		/// Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		/// values remove color. Positive values add color.
		/// </summary>
		public static void OffsetNonZeroColorsAllFramesName(string path, int red, int green, int blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginOffsetNonZeroColorsAllFramesName(lp_Path, red, green, blue);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double OffsetNonZeroColorsAllFramesNameD(string path, double red, double green, double blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginOffsetNonZeroColorsAllFramesNameD(lp_Path, red, green, blue);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// This method will only update colors in the animation that are not already 
		/// set to black. Offset a subset of colors in the frame using the RGB offset. 
		/// Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		/// values remove color. Positive values add color.
		/// </summary>
		public static void OffsetNonZeroColorsName(string path, int frameId, int red, int green, int blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginOffsetNonZeroColorsName(lp_Path, frameId, red, green, blue);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double OffsetNonZeroColorsNameD(string path, double frameId, double red, double green, double blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginOffsetNonZeroColorsNameD(lp_Path, frameId, red, green, blue);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Opens a `Chroma` animation file so that it can be played. Returns an animation 
		/// id >= 0 upon success. Returns negative one if there was a failure. The 
		/// animation id is used in most of the API methods.
		/// </summary>
		public static int OpenAnimation(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			int result = PluginOpenAnimation(lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double OpenAnimationD(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginOpenAnimationD(lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Opens a `Chroma` animation data from memory so that it can be played. `Data` 
		/// is a pointer to BYTE array of the loaded animation in memory. `Name` will 
		/// be assigned to the animation when loaded. Returns an animation id >= 0 
		/// upon success. Returns negative one if there was a failure. The animation 
		/// id is used in most of the API methods.
		/// </summary>
		public static int OpenAnimationFromMemory(byte[] data, string name)
		{
			string str_Name = name;
			IntPtr lp_Name = GetPathIntPtr(str_Name);
			int result = PluginOpenAnimationFromMemory(data, lp_Name);
			FreeIntPtr(lp_Name);
			return result;
		}
		/// <summary>
		/// Opens a `Chroma` animation file with the `.chroma` extension. Returns zero 
		/// upon success. Returns negative one if there was a failure.
		/// </summary>
		public static int OpenEditorDialog(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			int result = PluginOpenEditorDialog(lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Open the named animation in the editor dialog and play the animation at 
		/// start.
		/// </summary>
		public static int OpenEditorDialogAndPlay(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			int result = PluginOpenEditorDialogAndPlay(lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double OpenEditorDialogAndPlayD(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginOpenEditorDialogAndPlayD(lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double OpenEditorDialogD(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginOpenEditorDialogD(lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Sets the `duration` for all grames in the `Chroma` animation to the `duration` 
		/// parameter. Returns the animation id upon success. Returns negative one 
		/// upon failure.
		/// </summary>
		public static int OverrideFrameDuration(int animationId, float duration)
		{
			int result = PluginOverrideFrameDuration(animationId, duration);
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double OverrideFrameDurationD(double animationId, double duration)
		{
			double result = PluginOverrideFrameDurationD(animationId, duration);
			return result;
		}
		/// <summary>
		/// Override the duration of all frames with the `duration` value. Animation 
		/// is referenced by name.
		/// </summary>
		public static void OverrideFrameDurationName(string path, float duration)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginOverrideFrameDurationName(lp_Path, duration);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// Pause the current animation referenced by id.
		/// </summary>
		public static void PauseAnimation(int animationId)
		{
			PluginPauseAnimation(animationId);
		}
		/// <summary>
		/// Pause the current animation referenced by name.
		/// </summary>
		public static void PauseAnimationName(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginPauseAnimationName(lp_Path);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double PauseAnimationNameD(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginPauseAnimationNameD(lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Plays the `Chroma` animation. This will load the animation, if not loaded 
		/// previously. Returns the animation id upon success. Returns negative one 
		/// upon failure.
		/// </summary>
		public static int PlayAnimation(int animationId)
		{
			int result = PluginPlayAnimation(animationId);
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double PlayAnimationD(double animationId)
		{
			double result = PluginPlayAnimationD(animationId);
			return result;
		}
		/// <summary>
		/// `PluginPlayAnimationFrame` automatically handles initializing the `ChromaSDK`. 
		/// The method will play the animation given the `animationId` with looping 
		/// `on` or `off` starting at the `frameId`.
		/// </summary>
		public static void PlayAnimationFrame(int animationId, int frameId, bool loop)
		{
			PluginPlayAnimationFrame(animationId, frameId, loop);
		}
		/// <summary>
		/// `PluginPlayAnimationFrameName` automatically handles initializing the `ChromaSDK`. 
		/// The named `.chroma` animation file will be automatically opened. The animation 
		/// will play with looping `on` or `off` starting at the `frameId`.
		/// </summary>
		public static void PlayAnimationFrameName(string path, int frameId, bool loop)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginPlayAnimationFrameName(lp_Path, frameId, loop);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double PlayAnimationFrameNameD(string path, double frameId, double loop)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginPlayAnimationFrameNameD(lp_Path, frameId, loop);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// `PluginPlayAnimationLoop` automatically handles initializing the `ChromaSDK`. 
		/// The method will play the animation given the `animationId` with looping 
		/// `on` or `off`.
		/// </summary>
		public static void PlayAnimationLoop(int animationId, bool loop)
		{
			PluginPlayAnimationLoop(animationId, loop);
		}
		/// <summary>
		/// `PluginPlayAnimationName` automatically handles initializing the `ChromaSDK`. 
		/// The named `.chroma` animation file will be automatically opened. The animation 
		/// will play with looping `on` or `off`.
		/// </summary>
		public static void PlayAnimationName(string path, bool loop)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginPlayAnimationName(lp_Path, loop);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double PlayAnimationNameD(string path, double loop)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginPlayAnimationNameD(lp_Path, loop);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// `PluginPlayComposite` automatically handles initializing the `ChromaSDK`. 
		/// The named animation files for the `.chroma` set will be automatically opened. 
		/// The set of animations will play with looping `on` or `off`.
		/// </summary>
		public static void PlayComposite(string name, bool loop)
		{
			string str_Name = name;
			IntPtr lp_Name = GetPathIntPtr(str_Name);
			PluginPlayComposite(lp_Name, loop);
			FreeIntPtr(lp_Name);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double PlayCompositeD(string name, double loop)
		{
			string str_Name = name;
			IntPtr lp_Name = GetPathIntPtr(str_Name);
			double result = PluginPlayCompositeD(lp_Name, loop);
			FreeIntPtr(lp_Name);
			return result;
		}
		/// <summary>
		/// Displays the `Chroma` animation frame on `Chroma` hardware given the `frameIndex`. 
		/// Returns the animation id upon success. Returns negative one upon failure. 
		///
		/// </summary>
		public static int PreviewFrame(int animationId, int frameIndex)
		{
			int result = PluginPreviewFrame(animationId, frameIndex);
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double PreviewFrameD(double animationId, double frameIndex)
		{
			double result = PluginPreviewFrameD(animationId, frameIndex);
			return result;
		}
		/// <summary>
		/// Displays the `Chroma` animation frame on `Chroma` hardware given the `frameIndex`. 
		/// Animaton is referenced by name.
		/// </summary>
		public static void PreviewFrameName(string path, int frameIndex)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginPreviewFrameName(lp_Path, frameIndex);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// Reduce the frames of the animation by removing every nth element. Animation 
		/// is referenced by id.
		/// </summary>
		public static void ReduceFrames(int animationId, int n)
		{
			PluginReduceFrames(animationId, n);
		}
		/// <summary>
		/// Reduce the frames of the animation by removing every nth element. Animation 
		/// is referenced by name.
		/// </summary>
		public static void ReduceFramesName(string path, int n)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginReduceFramesName(lp_Path, n);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double ReduceFramesNameD(string path, double n)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginReduceFramesNameD(lp_Path, n);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Resets the `Chroma` animation to 1 blank frame. Returns the animation id 
		/// upon success. Returns negative one upon failure.
		/// </summary>
		public static int ResetAnimation(int animationId)
		{
			int result = PluginResetAnimation(animationId);
			return result;
		}
		/// <summary>
		/// Resume the animation with loop `ON` or `OFF` referenced by id.
		/// </summary>
		public static void ResumeAnimation(int animationId, bool loop)
		{
			PluginResumeAnimation(animationId, loop);
		}
		/// <summary>
		/// Resume the animation with loop `ON` or `OFF` referenced by name.
		/// </summary>
		public static void ResumeAnimationName(string path, bool loop)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginResumeAnimationName(lp_Path, loop);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double ResumeAnimationNameD(string path, double loop)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginResumeAnimationNameD(lp_Path, loop);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Reverse the animation frame order of the `Chroma` animation. Returns the 
		/// animation id upon success. Returns negative one upon failure. Animation 
		/// is referenced by id.
		/// </summary>
		public static int Reverse(int animationId)
		{
			int result = PluginReverse(animationId);
			return result;
		}
		/// <summary>
		/// Reverse the animation frame order of the `Chroma` animation. Animation is 
		/// referenced by id.
		/// </summary>
		public static void ReverseAllFrames(int animationId)
		{
			PluginReverseAllFrames(animationId);
		}
		/// <summary>
		/// Reverse the animation frame order of the `Chroma` animation. Animation is 
		/// referenced by name.
		/// </summary>
		public static void ReverseAllFramesName(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginReverseAllFramesName(lp_Path);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double ReverseAllFramesNameD(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginReverseAllFramesNameD(lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Save the animation referenced by id to the path specified.
		/// </summary>
		public static int SaveAnimation(int animationId, string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			int result = PluginSaveAnimation(animationId, lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Save the named animation to the target path specified.
		/// </summary>
		public static int SaveAnimationName(string sourceAnimation, string targetAnimation)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			int result = PluginSaveAnimationName(lp_SourceAnimation, lp_TargetAnimation);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Set the animation color for a frame given the `1D` `led`. The `led` should 
		/// be greater than or equal to 0 and less than the `MaxLeds`. The animation 
		/// is referenced by id.
		/// </summary>
		public static void Set1DColor(int animationId, int frameId, int led, int color)
		{
			PluginSet1DColor(animationId, frameId, led, color);
		}
		/// <summary>
		/// Set the animation color for a frame given the `1D` `led`. The `led` should 
		/// be greater than or equal to 0 and less than the `MaxLeds`. The animation 
		/// is referenced by name.
		/// </summary>
		public static void Set1DColorName(string path, int frameId, int led, int color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginSet1DColorName(lp_Path, frameId, led, color);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double Set1DColorNameD(string path, double frameId, double led, double color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginSet1DColorNameD(lp_Path, frameId, led, color);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Set the animation color for a frame given the `2D` `row` and `column`. The 
		/// `row` should be greater than or equal to 0 and less than the `MaxRow`. 
		/// The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		/// The animation is referenced by id.
		/// </summary>
		public static void Set2DColor(int animationId, int frameId, int row, int column, int color)
		{
			PluginSet2DColor(animationId, frameId, row, column, color);
		}
		/// <summary>
		/// Set the animation color for a frame given the `2D` `row` and `column`. The 
		/// `row` should be greater than or equal to 0 and less than the `MaxRow`. 
		/// The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		/// The animation is referenced by name.
		/// </summary>
		public static void Set2DColorName(string path, int frameId, int row, int column, int color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginSet2DColorName(lp_Path, frameId, row, column, color);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double Set2DColorNameD(string path, double frameId, double rowColumnIndex, double color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginSet2DColorNameD(lp_Path, frameId, rowColumnIndex, color);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// When custom color is set, the custom key mode will be used. The animation 
		/// is referenced by id.
		/// </summary>
		public static void SetChromaCustomColorAllFrames(int animationId)
		{
			PluginSetChromaCustomColorAllFrames(animationId);
		}
		/// <summary>
		/// When custom color is set, the custom key mode will be used. The animation 
		/// is referenced by name.
		/// </summary>
		public static void SetChromaCustomColorAllFramesName(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginSetChromaCustomColorAllFramesName(lp_Path);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double SetChromaCustomColorAllFramesNameD(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginSetChromaCustomColorAllFramesNameD(lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Set the Chroma custom key color flag on all frames. `True` changes the layout 
		/// from grid to key. `True` changes the layout from key to grid. Animation 
		/// is referenced by id.
		/// </summary>
		public static void SetChromaCustomFlag(int animationId, bool flag)
		{
			PluginSetChromaCustomFlag(animationId, flag);
		}
		/// <summary>
		/// Set the Chroma custom key color flag on all frames. `True` changes the layout 
		/// from grid to key. `True` changes the layout from key to grid. Animation 
		/// is referenced by name.
		/// </summary>
		public static void SetChromaCustomFlagName(string path, bool flag)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginSetChromaCustomFlagName(lp_Path, flag);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double SetChromaCustomFlagNameD(string path, double flag)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginSetChromaCustomFlagNameD(lp_Path, flag);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Set the current frame of the animation referenced by id.
		/// </summary>
		public static void SetCurrentFrame(int animationId, int frameId)
		{
			PluginSetCurrentFrame(animationId, frameId);
		}
		/// <summary>
		/// Set the current frame of the animation referenced by name.
		/// </summary>
		public static void SetCurrentFrameName(string path, int frameId)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginSetCurrentFrameName(lp_Path, frameId);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double SetCurrentFrameNameD(string path, double frameId)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginSetCurrentFrameNameD(lp_Path, frameId);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Set the custom alpha flag on the color array
		/// </summary>
		public static int SetCustomColorFlag2D(int device, int[] colors)
		{
			int result = PluginSetCustomColorFlag2D(device, colors);
			return result;
		}
		/// <summary>
		/// Changes the `deviceType` and `device` of a `Chroma` animation. If the device 
		/// is changed, the `Chroma` animation will be reset with 1 blank frame. Returns 
		/// the animation id upon success. Returns negative one upon failure.
		/// </summary>
		public static int SetDevice(int animationId, int deviceType, int device)
		{
			int result = PluginSetDevice(animationId, deviceType, device);
			return result;
		}
		/// <summary>
		/// SetEffect will display the referenced effect id.
		/// </summary>
		public static int SetEffect(Guid effectId)
		{
			int result = PluginSetEffect(effectId);
			return result;
		}
		/// <summary>
		/// SetEffectCustom1D will display the referenced colors immediately
		/// </summary>
		public static int SetEffectCustom1D(int device, int[] colors)
		{
			int result = PluginSetEffectCustom1D(device, colors);
			return result;
		}
		/// <summary>
		/// SetEffectCustom2D will display the referenced colors immediately
		/// </summary>
		public static int SetEffectCustom2D(int device, int[] colors)
		{
			int result = PluginSetEffectCustom2D(device, colors);
			return result;
		}
		/// <summary>
		/// SetEffectKeyboardCustom2D will display the referenced custom keyboard colors 
		/// immediately
		/// </summary>
		public static int SetEffectKeyboardCustom2D(int device, int[] colors)
		{
			int result = PluginSetEffectKeyboardCustom2D(device, colors);
			return result;
		}
		/// <summary>
		/// When the idle animation is used, the named animation will play when no other 
		/// animations are playing. Reference the animation by id.
		/// </summary>
		public static void SetIdleAnimation(int animationId)
		{
			PluginSetIdleAnimation(animationId);
		}
		/// <summary>
		/// When the idle animation is used, the named animation will play when no other 
		/// animations are playing. Reference the animation by name.
		/// </summary>
		public static void SetIdleAnimationName(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginSetIdleAnimationName(lp_Path);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// Set animation key to a static color for the given frame.
		/// </summary>
		public static void SetKeyColor(int animationId, int frameId, int rzkey, int color)
		{
			PluginSetKeyColor(animationId, frameId, rzkey, color);
		}
		/// <summary>
		/// Set the key to the specified key color for all frames. Animation is referenced 
		/// by id.
		/// </summary>
		public static void SetKeyColorAllFrames(int animationId, int rzkey, int color)
		{
			PluginSetKeyColorAllFrames(animationId, rzkey, color);
		}
		/// <summary>
		/// Set the key to the specified key color for all frames. Animation is referenced 
		/// by name.
		/// </summary>
		public static void SetKeyColorAllFramesName(string path, int rzkey, int color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginSetKeyColorAllFramesName(lp_Path, rzkey, color);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double SetKeyColorAllFramesNameD(string path, double rzkey, double color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginSetKeyColorAllFramesNameD(lp_Path, rzkey, color);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Set the key to the specified key color for all frames. Animation is referenced 
		/// by id.
		/// </summary>
		public static void SetKeyColorAllFramesRGB(int animationId, int rzkey, int red, int green, int blue)
		{
			PluginSetKeyColorAllFramesRGB(animationId, rzkey, red, green, blue);
		}
		/// <summary>
		/// Set the key to the specified key color for all frames. Animation is referenced 
		/// by name.
		/// </summary>
		public static void SetKeyColorAllFramesRGBName(string path, int rzkey, int red, int green, int blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginSetKeyColorAllFramesRGBName(lp_Path, rzkey, red, green, blue);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double SetKeyColorAllFramesRGBNameD(string path, double rzkey, double red, double green, double blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginSetKeyColorAllFramesRGBNameD(lp_Path, rzkey, red, green, blue);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Set animation key to a static color for the given frame.
		/// </summary>
		public static void SetKeyColorName(string path, int frameId, int rzkey, int color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginSetKeyColorName(lp_Path, frameId, rzkey, color);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double SetKeyColorNameD(string path, double frameId, double rzkey, double color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginSetKeyColorNameD(lp_Path, frameId, rzkey, color);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Set the key to the specified key color for the specified frame. Animation 
		/// is referenced by id.
		/// </summary>
		public static void SetKeyColorRGB(int animationId, int frameId, int rzkey, int red, int green, int blue)
		{
			PluginSetKeyColorRGB(animationId, frameId, rzkey, red, green, blue);
		}
		/// <summary>
		/// Set the key to the specified key color for the specified frame. Animation 
		/// is referenced by name.
		/// </summary>
		public static void SetKeyColorRGBName(string path, int frameId, int rzkey, int red, int green, int blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginSetKeyColorRGBName(lp_Path, frameId, rzkey, red, green, blue);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double SetKeyColorRGBNameD(string path, double frameId, double rzkey, double red, double green, double blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginSetKeyColorRGBNameD(lp_Path, frameId, rzkey, red, green, blue);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Set animation key to a static color for the given frame if the existing 
		/// color is not already black.
		/// </summary>
		public static void SetKeyNonZeroColor(int animationId, int frameId, int rzkey, int color)
		{
			PluginSetKeyNonZeroColor(animationId, frameId, rzkey, color);
		}
		/// <summary>
		/// Set animation key to a static color for the given frame if the existing 
		/// color is not already black.
		/// </summary>
		public static void SetKeyNonZeroColorName(string path, int frameId, int rzkey, int color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginSetKeyNonZeroColorName(lp_Path, frameId, rzkey, color);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double SetKeyNonZeroColorNameD(string path, double frameId, double rzkey, double color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginSetKeyNonZeroColorNameD(lp_Path, frameId, rzkey, color);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Set the key to the specified key color for the specified frame where color 
		/// is not black. Animation is referenced by id.
		/// </summary>
		public static void SetKeyNonZeroColorRGB(int animationId, int frameId, int rzkey, int red, int green, int blue)
		{
			PluginSetKeyNonZeroColorRGB(animationId, frameId, rzkey, red, green, blue);
		}
		/// <summary>
		/// Set the key to the specified key color for the specified frame where color 
		/// is not black. Animation is referenced by name.
		/// </summary>
		public static void SetKeyNonZeroColorRGBName(string path, int frameId, int rzkey, int red, int green, int blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginSetKeyNonZeroColorRGBName(lp_Path, frameId, rzkey, red, green, blue);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double SetKeyNonZeroColorRGBNameD(string path, double frameId, double rzkey, double red, double green, double blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginSetKeyNonZeroColorRGBNameD(lp_Path, frameId, rzkey, red, green, blue);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Set animation key by row and column to a static color for the given frame. 
		///
		/// </summary>
		public static void SetKeyRowColumnColorName(string path, int frameId, int row, int column, int color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginSetKeyRowColumnColorName(lp_Path, frameId, row, column, color);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// Set an array of animation keys to a static color for the given frame. Animation 
		/// is referenced by id.
		/// </summary>
		public static void SetKeysColor(int animationId, int frameId, int[] rzkeys, int keyCount, int color)
		{
			PluginSetKeysColor(animationId, frameId, rzkeys, keyCount, color);
		}
		/// <summary>
		/// Set an array of animation keys to a static color for all frames. Animation 
		/// is referenced by id.
		/// </summary>
		public static void SetKeysColorAllFrames(int animationId, int[] rzkeys, int keyCount, int color)
		{
			PluginSetKeysColorAllFrames(animationId, rzkeys, keyCount, color);
		}
		/// <summary>
		/// Set an array of animation keys to a static color for all frames. Animation 
		/// is referenced by name.
		/// </summary>
		public static void SetKeysColorAllFramesName(string path, int[] rzkeys, int keyCount, int color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginSetKeysColorAllFramesName(lp_Path, rzkeys, keyCount, color);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// Set an array of animation keys to a static color for all frames. Animation 
		/// is referenced by id.
		/// </summary>
		public static void SetKeysColorAllFramesRGB(int animationId, int[] rzkeys, int keyCount, int red, int green, int blue)
		{
			PluginSetKeysColorAllFramesRGB(animationId, rzkeys, keyCount, red, green, blue);
		}
		/// <summary>
		/// Set an array of animation keys to a static color for all frames. Animation 
		/// is referenced by name.
		/// </summary>
		public static void SetKeysColorAllFramesRGBName(string path, int[] rzkeys, int keyCount, int red, int green, int blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginSetKeysColorAllFramesRGBName(lp_Path, rzkeys, keyCount, red, green, blue);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// Set an array of animation keys to a static color for the given frame.
		/// </summary>
		public static void SetKeysColorName(string path, int frameId, int[] rzkeys, int keyCount, int color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginSetKeysColorName(lp_Path, frameId, rzkeys, keyCount, color);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// Set an array of animation keys to a static color for the given frame. Animation 
		/// is referenced by id.
		/// </summary>
		public static void SetKeysColorRGB(int animationId, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue)
		{
			PluginSetKeysColorRGB(animationId, frameId, rzkeys, keyCount, red, green, blue);
		}
		/// <summary>
		/// Set an array of animation keys to a static color for the given frame. Animation 
		/// is referenced by name.
		/// </summary>
		public static void SetKeysColorRGBName(string path, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginSetKeysColorRGBName(lp_Path, frameId, rzkeys, keyCount, red, green, blue);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// Set an array of animation keys to a static color for the given frame if 
		/// the existing color is not already black.
		/// </summary>
		public static void SetKeysNonZeroColor(int animationId, int frameId, int[] rzkeys, int keyCount, int color)
		{
			PluginSetKeysNonZeroColor(animationId, frameId, rzkeys, keyCount, color);
		}
		/// <summary>
		/// Set an array of animation keys to a static color for the given frame where 
		/// the color is not black. Animation is referenced by id.
		/// </summary>
		public static void SetKeysNonZeroColorAllFrames(int animationId, int[] rzkeys, int keyCount, int color)
		{
			PluginSetKeysNonZeroColorAllFrames(animationId, rzkeys, keyCount, color);
		}
		/// <summary>
		/// Set an array of animation keys to a static color for all frames if the existing 
		/// color is not already black. Reference animation by name.
		/// </summary>
		public static void SetKeysNonZeroColorAllFramesName(string path, int[] rzkeys, int keyCount, int color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginSetKeysNonZeroColorAllFramesName(lp_Path, rzkeys, keyCount, color);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// Set an array of animation keys to a static color for the given frame if 
		/// the existing color is not already black. Reference animation by name.
		/// </summary>
		public static void SetKeysNonZeroColorName(string path, int frameId, int[] rzkeys, int keyCount, int color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginSetKeysNonZeroColorName(lp_Path, frameId, rzkeys, keyCount, color);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// Set an array of animation keys to a static color for the given frame where 
		/// the color is not black. Animation is referenced by id.
		/// </summary>
		public static void SetKeysNonZeroColorRGB(int animationId, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue)
		{
			PluginSetKeysNonZeroColorRGB(animationId, frameId, rzkeys, keyCount, red, green, blue);
		}
		/// <summary>
		/// Set an array of animation keys to a static color for the given frame where 
		/// the color is not black. Animation is referenced by name.
		/// </summary>
		public static void SetKeysNonZeroColorRGBName(string path, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginSetKeysNonZeroColorRGBName(lp_Path, frameId, rzkeys, keyCount, red, green, blue);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// Set an array of animation keys to a static color for the given frame where 
		/// the color is black. Animation is referenced by id.
		/// </summary>
		public static void SetKeysZeroColor(int animationId, int frameId, int[] rzkeys, int keyCount, int color)
		{
			PluginSetKeysZeroColor(animationId, frameId, rzkeys, keyCount, color);
		}
		/// <summary>
		/// Set an array of animation keys to a static color for all frames where the 
		/// color is black. Animation is referenced by id.
		/// </summary>
		public static void SetKeysZeroColorAllFrames(int animationId, int[] rzkeys, int keyCount, int color)
		{
			PluginSetKeysZeroColorAllFrames(animationId, rzkeys, keyCount, color);
		}
		/// <summary>
		/// Set an array of animation keys to a static color for all frames where the 
		/// color is black. Animation is referenced by name.
		/// </summary>
		public static void SetKeysZeroColorAllFramesName(string path, int[] rzkeys, int keyCount, int color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginSetKeysZeroColorAllFramesName(lp_Path, rzkeys, keyCount, color);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// Set an array of animation keys to a static color for all frames where the 
		/// color is black. Animation is referenced by id.
		/// </summary>
		public static void SetKeysZeroColorAllFramesRGB(int animationId, int[] rzkeys, int keyCount, int red, int green, int blue)
		{
			PluginSetKeysZeroColorAllFramesRGB(animationId, rzkeys, keyCount, red, green, blue);
		}
		/// <summary>
		/// Set an array of animation keys to a static color for all frames where the 
		/// color is black. Animation is referenced by name.
		/// </summary>
		public static void SetKeysZeroColorAllFramesRGBName(string path, int[] rzkeys, int keyCount, int red, int green, int blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginSetKeysZeroColorAllFramesRGBName(lp_Path, rzkeys, keyCount, red, green, blue);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// Set an array of animation keys to a static color for the given frame where 
		/// the color is black. Animation is referenced by name.
		/// </summary>
		public static void SetKeysZeroColorName(string path, int frameId, int[] rzkeys, int keyCount, int color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginSetKeysZeroColorName(lp_Path, frameId, rzkeys, keyCount, color);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// Set an array of animation keys to a static color for the given frame where 
		/// the color is black. Animation is referenced by id.
		/// </summary>
		public static void SetKeysZeroColorRGB(int animationId, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue)
		{
			PluginSetKeysZeroColorRGB(animationId, frameId, rzkeys, keyCount, red, green, blue);
		}
		/// <summary>
		/// Set an array of animation keys to a static color for the given frame where 
		/// the color is black. Animation is referenced by name.
		/// </summary>
		public static void SetKeysZeroColorRGBName(string path, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginSetKeysZeroColorRGBName(lp_Path, frameId, rzkeys, keyCount, red, green, blue);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// Set animation key to a static color for the given frame where the color 
		/// is black. Animation is referenced by id.
		/// </summary>
		public static void SetKeyZeroColor(int animationId, int frameId, int rzkey, int color)
		{
			PluginSetKeyZeroColor(animationId, frameId, rzkey, color);
		}
		/// <summary>
		/// Set animation key to a static color for the given frame where the color 
		/// is black. Animation is referenced by name.
		/// </summary>
		public static void SetKeyZeroColorName(string path, int frameId, int rzkey, int color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginSetKeyZeroColorName(lp_Path, frameId, rzkey, color);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double SetKeyZeroColorNameD(string path, double frameId, double rzkey, double color)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginSetKeyZeroColorNameD(lp_Path, frameId, rzkey, color);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Set animation key to a static color for the given frame where the color 
		/// is black. Animation is referenced by id.
		/// </summary>
		public static void SetKeyZeroColorRGB(int animationId, int frameId, int rzkey, int red, int green, int blue)
		{
			PluginSetKeyZeroColorRGB(animationId, frameId, rzkey, red, green, blue);
		}
		/// <summary>
		/// Set animation key to a static color for the given frame where the color 
		/// is black. Animation is referenced by name.
		/// </summary>
		public static void SetKeyZeroColorRGBName(string path, int frameId, int rzkey, int red, int green, int blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginSetKeyZeroColorRGBName(lp_Path, frameId, rzkey, red, green, blue);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double SetKeyZeroColorRGBNameD(string path, double frameId, double rzkey, double red, double green, double blue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginSetKeyZeroColorRGBNameD(lp_Path, frameId, rzkey, red, green, blue);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Invokes the setup for a debug logging callback so that `stdout` is redirected 
		/// to the callback. This is used by `Unity` so that debug messages can appear 
		/// in the console window.
		/// </summary>
		public static void SetLogDelegate(IntPtr fp)
		{
			PluginSetLogDelegate(fp);
		}
		/// <summary>
		/// Sets the target device to the static color.
		/// </summary>
		public static void SetStaticColor(int deviceType, int device, int color)
		{
			PluginSetStaticColor(deviceType, device, color);
		}
		/// <summary>
		/// Sets all devices to the static color.
		/// </summary>
		public static void SetStaticColorAll(int color)
		{
			PluginSetStaticColorAll(color);
		}
		/// <summary>
		/// Sets the target device to the static color.
		/// </summary>
		public static void StaticColor(int deviceType, int device, int color)
		{
			PluginStaticColor(deviceType, device, color);
		}
		/// <summary>
		/// Sets all devices to the static color.
		/// </summary>
		public static void StaticColorAll(int color)
		{
			PluginStaticColorAll(color);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double StaticColorD(double deviceType, double device, double color)
		{
			double result = PluginStaticColorD(deviceType, device, color);
			return result;
		}
		/// <summary>
		/// `PluginStopAll` will automatically stop all animations that are playing. 
		///
		/// </summary>
		public static void StopAll()
		{
			PluginStopAll();
		}
		/// <summary>
		/// Stops animation playback if in progress. Returns the animation id upon success. 
		/// Returns negative one upon failure.
		/// </summary>
		public static int StopAnimation(int animationId)
		{
			int result = PluginStopAnimation(animationId);
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double StopAnimationD(double animationId)
		{
			double result = PluginStopAnimationD(animationId);
			return result;
		}
		/// <summary>
		/// `PluginStopAnimationName` automatically handles initializing the `ChromaSDK`. 
		/// The named `.chroma` animation file will be automatically opened. The animation 
		/// will stop if playing.
		/// </summary>
		public static void StopAnimationName(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginStopAnimationName(lp_Path);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double StopAnimationNameD(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginStopAnimationNameD(lp_Path);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// `PluginStopAnimationType` automatically handles initializing the `ChromaSDK`. 
		/// If any animation is playing for the `deviceType` and `device` combination, 
		/// it will be stopped.
		/// </summary>
		public static void StopAnimationType(int deviceType, int device)
		{
			PluginStopAnimationType(deviceType, device);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double StopAnimationTypeD(double deviceType, double device)
		{
			double result = PluginStopAnimationTypeD(deviceType, device);
			return result;
		}
		/// <summary>
		/// `PluginStopComposite` automatically handles initializing the `ChromaSDK`. 
		/// The named animation files for the `.chroma` set will be automatically opened. 
		/// The set of animations will be stopped if playing.
		/// </summary>
		public static void StopComposite(string name)
		{
			string str_Name = name;
			IntPtr lp_Name = GetPathIntPtr(str_Name);
			PluginStopComposite(lp_Name);
			FreeIntPtr(lp_Name);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double StopCompositeD(string name)
		{
			string str_Name = name;
			IntPtr lp_Name = GetPathIntPtr(str_Name);
			double result = PluginStopCompositeD(lp_Name);
			FreeIntPtr(lp_Name);
			return result;
		}
		/// <summary>
		/// Return color1 - color2
		/// </summary>
		public static int SubtractColor(int color1, int color2)
		{
			int result = PluginSubtractColor(color1, color2);
			return result;
		}
		/// <summary>
		/// Subtract the source color from the target color for the frame where the 
		/// target color is not black. Source and target are referenced by id.
		/// </summary>
		public static void SubtractNonZeroAllKeys(int sourceAnimationId, int targetAnimationId, int frameId)
		{
			PluginSubtractNonZeroAllKeys(sourceAnimationId, targetAnimationId, frameId);
		}
		/// <summary>
		/// Subtract the source color from the target color for all frames where the 
		/// target color is not black. Source and target are referenced by id.
		/// </summary>
		public static void SubtractNonZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId)
		{
			PluginSubtractNonZeroAllKeysAllFrames(sourceAnimationId, targetAnimationId);
		}
		/// <summary>
		/// Subtract the source color from the target color for all frames where the 
		/// target color is not black. Source and target are referenced by name.
		/// </summary>
		public static void SubtractNonZeroAllKeysAllFramesName(string sourceAnimation, string targetAnimation)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginSubtractNonZeroAllKeysAllFramesName(lp_SourceAnimation, lp_TargetAnimation);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double SubtractNonZeroAllKeysAllFramesNameD(string sourceAnimation, string targetAnimation)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginSubtractNonZeroAllKeysAllFramesNameD(lp_SourceAnimation, lp_TargetAnimation);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Subtract the source color from the target color for all frames where the 
		/// target color is not black starting at offset for the length of the source. 
		/// Source and target are referenced by id.
		/// </summary>
		public static void SubtractNonZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset)
		{
			PluginSubtractNonZeroAllKeysAllFramesOffset(sourceAnimationId, targetAnimationId, offset);
		}
		/// <summary>
		/// Subtract the source color from the target color for all frames where the 
		/// target color is not black starting at offset for the length of the source. 
		/// Source and target are referenced by name.
		/// </summary>
		public static void SubtractNonZeroAllKeysAllFramesOffsetName(string sourceAnimation, string targetAnimation, int offset)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginSubtractNonZeroAllKeysAllFramesOffsetName(lp_SourceAnimation, lp_TargetAnimation, offset);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double SubtractNonZeroAllKeysAllFramesOffsetNameD(string sourceAnimation, string targetAnimation, double offset)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginSubtractNonZeroAllKeysAllFramesOffsetNameD(lp_SourceAnimation, lp_TargetAnimation, offset);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Subtract the source color from the target color for the frame where the 
		/// target color is not black. Source and target are referenced by name.
		/// </summary>
		public static void SubtractNonZeroAllKeysName(string sourceAnimation, string targetAnimation, int frameId)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginSubtractNonZeroAllKeysName(lp_SourceAnimation, lp_TargetAnimation, frameId);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// Subtract the source color from the target where color is not black for the 
		/// source frame and target offset frame, reference source and target by id. 
		///
		/// </summary>
		public static void SubtractNonZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset)
		{
			PluginSubtractNonZeroAllKeysOffset(sourceAnimationId, targetAnimationId, frameId, offset);
		}
		/// <summary>
		/// Subtract the source color from the target where color is not black for the 
		/// source frame and target offset frame, reference source and target by name. 
		///
		/// </summary>
		public static void SubtractNonZeroAllKeysOffsetName(string sourceAnimation, string targetAnimation, int frameId, int offset)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginSubtractNonZeroAllKeysOffsetName(lp_SourceAnimation, lp_TargetAnimation, frameId, offset);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double SubtractNonZeroAllKeysOffsetNameD(string sourceAnimation, string targetAnimation, double frameId, double offset)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginSubtractNonZeroAllKeysOffsetNameD(lp_SourceAnimation, lp_TargetAnimation, frameId, offset);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Subtract the source color from the target color where the target color is 
		/// not black for all frames. Reference source and target by id.
		/// </summary>
		public static void SubtractNonZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId)
		{
			PluginSubtractNonZeroTargetAllKeysAllFrames(sourceAnimationId, targetAnimationId);
		}
		/// <summary>
		/// Subtract the source color from the target color where the target color is 
		/// not black for all frames. Reference source and target by name.
		/// </summary>
		public static void SubtractNonZeroTargetAllKeysAllFramesName(string sourceAnimation, string targetAnimation)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginSubtractNonZeroTargetAllKeysAllFramesName(lp_SourceAnimation, lp_TargetAnimation);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double SubtractNonZeroTargetAllKeysAllFramesNameD(string sourceAnimation, string targetAnimation)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginSubtractNonZeroTargetAllKeysAllFramesNameD(lp_SourceAnimation, lp_TargetAnimation);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Subtract the source color from the target color where the target color is 
		/// not black for all frames starting at the target offset for the length of 
		/// the source. Reference source and target by id.
		/// </summary>
		public static void SubtractNonZeroTargetAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset)
		{
			PluginSubtractNonZeroTargetAllKeysAllFramesOffset(sourceAnimationId, targetAnimationId, offset);
		}
		/// <summary>
		/// Subtract the source color from the target color where the target color is 
		/// not black for all frames starting at the target offset for the length of 
		/// the source. Reference source and target by name.
		/// </summary>
		public static void SubtractNonZeroTargetAllKeysAllFramesOffsetName(string sourceAnimation, string targetAnimation, int offset)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginSubtractNonZeroTargetAllKeysAllFramesOffsetName(lp_SourceAnimation, lp_TargetAnimation, offset);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double SubtractNonZeroTargetAllKeysAllFramesOffsetNameD(string sourceAnimation, string targetAnimation, double offset)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginSubtractNonZeroTargetAllKeysAllFramesOffsetNameD(lp_SourceAnimation, lp_TargetAnimation, offset);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Subtract the source color from the target color where the target color is 
		/// not black from the source frame to the target offset frame. Reference source 
		/// and target by id.
		/// </summary>
		public static void SubtractNonZeroTargetAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset)
		{
			PluginSubtractNonZeroTargetAllKeysOffset(sourceAnimationId, targetAnimationId, frameId, offset);
		}
		/// <summary>
		/// Subtract the source color from the target color where the target color is 
		/// not black from the source frame to the target offset frame. Reference source 
		/// and target by name.
		/// </summary>
		public static void SubtractNonZeroTargetAllKeysOffsetName(string sourceAnimation, string targetAnimation, int frameId, int offset)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			PluginSubtractNonZeroTargetAllKeysOffsetName(lp_SourceAnimation, lp_TargetAnimation, frameId, offset);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double SubtractNonZeroTargetAllKeysOffsetNameD(string sourceAnimation, string targetAnimation, double frameId, double offset)
		{
			string str_SourceAnimation = sourceAnimation;
			IntPtr lp_SourceAnimation = GetPathIntPtr(str_SourceAnimation);
			string str_TargetAnimation = targetAnimation;
			IntPtr lp_TargetAnimation = GetPathIntPtr(str_TargetAnimation);
			double result = PluginSubtractNonZeroTargetAllKeysOffsetNameD(lp_SourceAnimation, lp_TargetAnimation, frameId, offset);
			FreeIntPtr(lp_SourceAnimation);
			FreeIntPtr(lp_TargetAnimation);
			return result;
		}
		/// <summary>
		/// Subtract all frames with the min RGB color where the animation color is 
		/// less than the min threshold AND with the max RGB color where the animation 
		/// is more than the max threshold. Animation is referenced by id.
		/// </summary>
		public static void SubtractThresholdColorsMinMaxAllFramesRGB(int animationId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue)
		{
			PluginSubtractThresholdColorsMinMaxAllFramesRGB(animationId, minThreshold, minRed, minGreen, minBlue, maxThreshold, maxRed, maxGreen, maxBlue);
		}
		/// <summary>
		/// Subtract all frames with the min RGB color where the animation color is 
		/// less than the min threshold AND with the max RGB color where the animation 
		/// is more than the max threshold. Animation is referenced by name.
		/// </summary>
		public static void SubtractThresholdColorsMinMaxAllFramesRGBName(string path, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginSubtractThresholdColorsMinMaxAllFramesRGBName(lp_Path, minThreshold, minRed, minGreen, minBlue, maxThreshold, maxRed, maxGreen, maxBlue);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double SubtractThresholdColorsMinMaxAllFramesRGBNameD(string path, double minThreshold, double minRed, double minGreen, double minBlue, double maxThreshold, double maxRed, double maxGreen, double maxBlue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginSubtractThresholdColorsMinMaxAllFramesRGBNameD(lp_Path, minThreshold, minRed, minGreen, minBlue, maxThreshold, maxRed, maxGreen, maxBlue);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Subtract the specified frame with the min RGB color where the animation 
		/// color is less than the min threshold AND with the max RGB color where the 
		/// animation is more than the max threshold. Animation is referenced by id. 
		///
		/// </summary>
		public static void SubtractThresholdColorsMinMaxRGB(int animationId, int frameId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue)
		{
			PluginSubtractThresholdColorsMinMaxRGB(animationId, frameId, minThreshold, minRed, minGreen, minBlue, maxThreshold, maxRed, maxGreen, maxBlue);
		}
		/// <summary>
		/// Subtract the specified frame with the min RGB color where the animation 
		/// color is less than the min threshold AND with the max RGB color where the 
		/// animation is more than the max threshold. Animation is referenced by name. 
		///
		/// </summary>
		public static void SubtractThresholdColorsMinMaxRGBName(string path, int frameId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginSubtractThresholdColorsMinMaxRGBName(lp_Path, frameId, minThreshold, minRed, minGreen, minBlue, maxThreshold, maxRed, maxGreen, maxBlue);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double SubtractThresholdColorsMinMaxRGBNameD(string path, int frameId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginSubtractThresholdColorsMinMaxRGBNameD(lp_Path, frameId, minThreshold, minRed, minGreen, minBlue, maxThreshold, maxRed, maxGreen, maxBlue);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Trim the end of the animation. The length of the animation will be the lastFrameId 
		/// plus one. Reference the animation by id.
		/// </summary>
		public static void TrimEndFrames(int animationId, int lastFrameId)
		{
			PluginTrimEndFrames(animationId, lastFrameId);
		}
		/// <summary>
		/// Trim the end of the animation. The length of the animation will be the lastFrameId 
		/// plus one. Reference the animation by name.
		/// </summary>
		public static void TrimEndFramesName(string path, int lastFrameId)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginTrimEndFramesName(lp_Path, lastFrameId);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double TrimEndFramesNameD(string path, double lastFrameId)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginTrimEndFramesNameD(lp_Path, lastFrameId);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Remove the frame from the animation. Reference animation by id.
		/// </summary>
		public static void TrimFrame(int animationId, int frameId)
		{
			PluginTrimFrame(animationId, frameId);
		}
		/// <summary>
		/// Remove the frame from the animation. Reference animation by name.
		/// </summary>
		public static void TrimFrameName(string path, int frameId)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginTrimFrameName(lp_Path, frameId);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double TrimFrameNameD(string path, double frameId)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginTrimFrameNameD(lp_Path, frameId);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Trim the start of the animation starting at frame 0 for the number of frames. 
		/// Reference the animation by id.
		/// </summary>
		public static void TrimStartFrames(int animationId, int numberOfFrames)
		{
			PluginTrimStartFrames(animationId, numberOfFrames);
		}
		/// <summary>
		/// Trim the start of the animation starting at frame 0 for the number of frames. 
		/// Reference the animation by name.
		/// </summary>
		public static void TrimStartFramesName(string path, int numberOfFrames)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginTrimStartFramesName(lp_Path, numberOfFrames);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double TrimStartFramesNameD(string path, double numberOfFrames)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			double result = PluginTrimStartFramesNameD(lp_Path, numberOfFrames);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// Uninitializes the `ChromaSDK`. Returns 0 upon success. Returns negative 
		/// one upon failure.
		/// </summary>
		public static int Uninit()
		{
			int result = PluginUninit();
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double UninitD()
		{
			double result = PluginUninitD();
			return result;
		}
		/// <summary>
		/// Unloads `Chroma` effects to free up resources. Returns the animation id 
		/// upon success. Returns negative one upon failure. Reference the animation 
		/// by id.
		/// </summary>
		public static int UnloadAnimation(int animationId)
		{
			int result = PluginUnloadAnimation(animationId);
			return result;
		}
		/// <summary>
		/// D suffix for limited data types.
		/// </summary>
		public static double UnloadAnimationD(double animationId)
		{
			double result = PluginUnloadAnimationD(animationId);
			return result;
		}
		/// <summary>
		/// Unload the animation effects. Reference the animation by name.
		/// </summary>
		public static void UnloadAnimationName(string path)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginUnloadAnimationName(lp_Path);
			FreeIntPtr(lp_Path);
		}
		/// <summary>
		/// Unload the the composite set of animation effects. Reference the animation 
		/// by name.
		/// </summary>
		public static void UnloadComposite(string name)
		{
			string str_Name = name;
			IntPtr lp_Name = GetPathIntPtr(str_Name);
			PluginUnloadComposite(lp_Name);
			FreeIntPtr(lp_Name);
		}
		/// <summary>
		/// Unload the Razer Chroma SDK Library before exiting the application.
		/// </summary>
		public static void UnloadLibrarySDK()
		{
			PluginUnloadLibrarySDK();
		}
		/// <summary>
		/// Unload the Razer Chroma Streaming Plugin Library before exiting the application. 
		///
		/// </summary>
		public static void UnloadLibraryStreamingPlugin()
		{
			PluginUnloadLibraryStreamingPlugin();
		}
		/// <summary>
		/// Updates the `frameIndex` of the `Chroma` animation and sets the `duration` 
		/// (in seconds). The `color` is expected to be an array of the dimensions 
		/// for the `deviceType/device`. The `length` parameter is the size of the 
		/// `color` array. For `EChromaSDKDevice1DEnum` the array size should be `MAX 
		/// LEDS`. For `EChromaSDKDevice2DEnum` the array size should be `MAX ROW` 
		/// times `MAX COLUMN`. Returns the animation id upon success. Returns negative 
		/// one upon failure.
		/// </summary>
		public static int UpdateFrame(int animationId, int frameIndex, float duration, int[] colors, int length)
		{
			int result = PluginUpdateFrame(animationId, frameIndex, duration, colors, length);
			return result;
		}
		/// <summary>
		/// Updates the `frameIndex` of the `Chroma` animation and sets the `duration` 
		/// (in seconds). The `color` is expected to be an array of the dimensions 
		/// for the `deviceType/device`. The `length` parameter is the size of the 
		/// `color` array. For `EChromaSDKDevice1DEnum` the array size should be `MAX 
		/// LEDS`. For `EChromaSDKDevice2DEnum` the array size should be `MAX ROW` 
		/// times `MAX COLUMN`. Returns the animation id upon success. Returns negative 
		/// one upon failure.
		/// </summary>
		public static int UpdateFrameName(string path, int frameIndex, float duration, int[] colors, int length)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			int result = PluginUpdateFrameName(lp_Path, frameIndex, duration, colors, length);
			FreeIntPtr(lp_Path);
			return result;
		}
		/// <summary>
		/// When the idle animation flag is true, when no other animations are playing, 
		/// the idle animation will be used. The idle animation will not be affected 
		/// by the API calls to PluginIsPlaying, PluginStopAnimationType, PluginGetPlayingAnimationId, 
		/// and PluginGetPlayingAnimationCount. Then the idle animation flag is false, 
		/// the idle animation is disabled. `Device` uses `EChromaSDKDeviceEnum` enums. 
		///
		/// </summary>
		public static void UseIdleAnimation(int device, bool flag)
		{
			PluginUseIdleAnimation(device, flag);
		}
		/// <summary>
		/// Set idle animation flag for all devices.
		/// </summary>
		public static void UseIdleAnimations(bool flag)
		{
			PluginUseIdleAnimations(flag);
		}
		/// <summary>
		/// Set preloading animation flag, which is set to true by default. Reference 
		/// animation by id.
		/// </summary>
		public static void UsePreloading(int animationId, bool flag)
		{
			PluginUsePreloading(animationId, flag);
		}
		/// <summary>
		/// Set preloading animation flag, which is set to true by default. Reference 
		/// animation by name.
		/// </summary>
		public static void UsePreloadingName(string path, bool flag)
		{
			string str_Path = path;
			IntPtr lp_Path = GetPathIntPtr(str_Path);
			PluginUsePreloadingName(lp_Path, flag);
			FreeIntPtr(lp_Path);
		}
		#endregion

		#region Private DLL Hooks
		/// <summary>
		/// Return the sum of colors
		/// EXPORT_API int PluginAddColor(const int color1, const int color2);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginAddColor(int color1, int color2);
		/// <summary>
		/// Adds a frame to the `Chroma` animation and sets the `duration` (in seconds). 
		/// The `color` is expected to be an array of the dimensions for the `deviceType/device`. 
		/// The `length` parameter is the size of the `color` array. For `EChromaSDKDevice1DEnum` 
		/// the array size should be `MAX LEDS`. For `EChromaSDKDevice2DEnum` the array 
		/// size should be `MAX ROW` times `MAX COLUMN`. Returns the animation id upon 
		/// success. Returns negative one upon failure.
		/// EXPORT_API int PluginAddFrame(int animationId, float duration, int* colors, int length);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginAddFrame(int animationId, float duration, int[] colors, int length);
		/// <summary>
		/// Add source color to target where color is not black for frame id, reference 
		/// source and target by id.
		/// EXPORT_API void PluginAddNonZeroAllKeys(int sourceAnimationId, int targetAnimationId, int frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginAddNonZeroAllKeys(int sourceAnimationId, int targetAnimationId, int frameId);
		/// <summary>
		/// Add source color to target where color is not black for all frames, reference 
		/// source and target by id.
		/// EXPORT_API void PluginAddNonZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginAddNonZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
		/// <summary>
		/// Add source color to target where color is not black for all frames, reference 
		/// source and target by name.
		/// EXPORT_API void PluginAddNonZeroAllKeysAllFramesName(const char* sourceAnimation, const char* targetAnimation);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginAddNonZeroAllKeysAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginAddNonZeroAllKeysAllFramesNameD(const char* sourceAnimation, const char* targetAnimation);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginAddNonZeroAllKeysAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
		/// <summary>
		/// Add source color to target where color is not black for all frames starting 
		/// at offset for the length of the source, reference source and target by 
		/// id.
		/// EXPORT_API void PluginAddNonZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginAddNonZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
		/// <summary>
		/// Add source color to target where color is not black for all frames starting 
		/// at offset for the length of the source, reference source and target by 
		/// name.
		/// EXPORT_API void PluginAddNonZeroAllKeysAllFramesOffsetName(const char* sourceAnimation, const char* targetAnimation, int offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginAddNonZeroAllKeysAllFramesOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int offset);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginAddNonZeroAllKeysAllFramesOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginAddNonZeroAllKeysAllFramesOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double offset);
		/// <summary>
		/// Add source color to target where color is not black for frame id, reference 
		/// source and target by name.
		/// EXPORT_API void PluginAddNonZeroAllKeysName(const char* sourceAnimation, const char* targetAnimation, int frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginAddNonZeroAllKeysName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId);
		/// <summary>
		/// Add source color to target where color is not black for the source frame 
		/// and target offset frame, reference source and target by id.
		/// EXPORT_API void PluginAddNonZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginAddNonZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
		/// <summary>
		/// Add source color to target where color is not black for the source frame 
		/// and target offset frame, reference source and target by name.
		/// EXPORT_API void PluginAddNonZeroAllKeysOffsetName(const char* sourceAnimation, const char* targetAnimation, int frameId, int offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginAddNonZeroAllKeysOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId, int offset);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginAddNonZeroAllKeysOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double frameId, double offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginAddNonZeroAllKeysOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId, double offset);
		/// <summary>
		/// Add source color to target where the target color is not black for all frames, 
		/// reference source and target by id.
		/// EXPORT_API void PluginAddNonZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginAddNonZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
		/// <summary>
		/// Add source color to target where the target color is not black for all frames, 
		/// reference source and target by name.
		/// EXPORT_API void PluginAddNonZeroTargetAllKeysAllFramesName(const char* sourceAnimation, const char* targetAnimation);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginAddNonZeroTargetAllKeysAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginAddNonZeroTargetAllKeysAllFramesNameD(const char* sourceAnimation, const char* targetAnimation);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginAddNonZeroTargetAllKeysAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
		/// <summary>
		/// Add source color to target where the target color is not black for all frames 
		/// starting at offset for the length of the source, reference source and target 
		/// by id.
		/// EXPORT_API void PluginAddNonZeroTargetAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginAddNonZeroTargetAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
		/// <summary>
		/// Add source color to target where the target color is not black for all frames 
		/// starting at offset for the length of the source, reference source and target 
		/// by name.
		/// EXPORT_API void PluginAddNonZeroTargetAllKeysAllFramesOffsetName(const char* sourceAnimation, const char* targetAnimation, int offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginAddNonZeroTargetAllKeysAllFramesOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int offset);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginAddNonZeroTargetAllKeysAllFramesOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginAddNonZeroTargetAllKeysAllFramesOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double offset);
		/// <summary>
		/// Add source color to target where target color is not blank from the source 
		/// frame to the target offset frame, reference source and target by id.
		/// EXPORT_API void PluginAddNonZeroTargetAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginAddNonZeroTargetAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
		/// <summary>
		/// Add source color to target where target color is not blank from the source 
		/// frame to the target offset frame, reference source and target by name. 
		///
		/// EXPORT_API void PluginAddNonZeroTargetAllKeysOffsetName(const char* sourceAnimation, const char* targetAnimation, int frameId, int offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginAddNonZeroTargetAllKeysOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId, int offset);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginAddNonZeroTargetAllKeysOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double frameId, double offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginAddNonZeroTargetAllKeysOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId, double offset);
		/// <summary>
		/// Append all source frames to the target animation, reference source and target 
		/// by id.
		/// EXPORT_API void PluginAppendAllFrames(int sourceAnimationId, int targetAnimationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginAppendAllFrames(int sourceAnimationId, int targetAnimationId);
		/// <summary>
		/// Append all source frames to the target animation, reference source and target 
		/// by name.
		/// EXPORT_API void PluginAppendAllFramesName(const char* sourceAnimation, const char* targetAnimation);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginAppendAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginAppendAllFramesNameD(const char* sourceAnimation, const char* targetAnimation);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginAppendAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
		/// <summary>
		/// `PluginClearAll` will issue a `CLEAR` effect for all devices.
		/// EXPORT_API void PluginClearAll();
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginClearAll();
		/// <summary>
		/// `PluginClearAnimationType` will issue a `CLEAR` effect for the given device. 
		///
		/// EXPORT_API void PluginClearAnimationType(int deviceType, int device);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginClearAnimationType(int deviceType, int device);
		/// <summary>
		/// `PluginCloseAll` closes all open animations so they can be reloaded from 
		/// disk. The set of animations will be stopped if playing.
		/// EXPORT_API void PluginCloseAll();
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCloseAll();
		/// <summary>
		/// Closes the `Chroma` animation to free up resources referenced by id. Returns 
		/// the animation id upon success. Returns negative one upon failure. This 
		/// might be used while authoring effects if there was a change necessitating 
		/// re-opening the animation. The animation id can no longer be used once closed. 
		///
		/// EXPORT_API int PluginCloseAnimation(int animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginCloseAnimation(int animationId);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginCloseAnimationD(double animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginCloseAnimationD(double animationId);
		/// <summary>
		/// Closes the `Chroma` animation referenced by name so that the animation can 
		/// be reloaded from disk.
		/// EXPORT_API void PluginCloseAnimationName(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCloseAnimationName(IntPtr path);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginCloseAnimationNameD(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginCloseAnimationNameD(IntPtr path);
		/// <summary>
		/// `PluginCloseComposite` closes a set of animations so they can be reloaded 
		/// from disk. The set of animations will be stopped if playing.
		/// EXPORT_API void PluginCloseComposite(const char* name);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCloseComposite(IntPtr name);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginCloseCompositeD(const char* name);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginCloseCompositeD(IntPtr name);
		/// <summary>
		/// Copy source animation to target animation for the given frame. Source and 
		/// target are referenced by id.
		/// EXPORT_API void PluginCopyAllKeys(int sourceAnimationId, int targetAnimationId, int frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyAllKeys(int sourceAnimationId, int targetAnimationId, int frameId);
		/// <summary>
		/// Copy source animation to target animation for the given frame. Source and 
		/// target are referenced by id.
		/// EXPORT_API void PluginCopyAllKeysName(const char* sourceAnimation, const char* targetAnimation, int frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyAllKeysName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId);
		/// <summary>
		/// Copy animation to named target animation in memory. If target animation 
		/// exists, close first. Source is referenced by id.
		/// EXPORT_API int PluginCopyAnimation(int sourceAnimationId, const char* targetAnimation);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginCopyAnimation(int sourceAnimationId, IntPtr targetAnimation);
		/// <summary>
		/// Copy animation to named target animation in memory. If target animation 
		/// exists, close first. Source is referenced by name.
		/// EXPORT_API void PluginCopyAnimationName(const char* sourceAnimation, const char* targetAnimation);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyAnimationName(IntPtr sourceAnimation, IntPtr targetAnimation);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginCopyAnimationNameD(const char* sourceAnimation, const char* targetAnimation);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginCopyAnimationNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
		/// <summary>
		/// Copy blue channel to other channels for all frames. Intensity range is 0.0 
		/// to 1.0. Reference the animation by id.
		/// EXPORT_API void PluginCopyBlueChannelAllFrames(int animationId, float redIntensity, float greenIntensity);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyBlueChannelAllFrames(int animationId, float redIntensity, float greenIntensity);
		/// <summary>
		/// Copy blue channel to other channels for all frames. Intensity range is 0.0 
		/// to 1.0. Reference the animation by name.
		/// EXPORT_API void PluginCopyBlueChannelAllFramesName(const char* path, float redIntensity, float greenIntensity);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyBlueChannelAllFramesName(IntPtr path, float redIntensity, float greenIntensity);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginCopyBlueChannelAllFramesNameD(const char* path, double redIntensity, double greenIntensity);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginCopyBlueChannelAllFramesNameD(IntPtr path, double redIntensity, double greenIntensity);
		/// <summary>
		/// Copy green channel to other channels for all frames. Intensity range is 
		/// 0.0 to 1.0. Reference the animation by id.
		/// EXPORT_API void PluginCopyGreenChannelAllFrames(int animationId, float redIntensity, float blueIntensity);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyGreenChannelAllFrames(int animationId, float redIntensity, float blueIntensity);
		/// <summary>
		/// Copy green channel to other channels for all frames. Intensity range is 
		/// 0.0 to 1.0. Reference the animation by name.
		/// EXPORT_API void PluginCopyGreenChannelAllFramesName(const char* path, float redIntensity, float blueIntensity);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyGreenChannelAllFramesName(IntPtr path, float redIntensity, float blueIntensity);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginCopyGreenChannelAllFramesNameD(const char* path, double redIntensity, double blueIntensity);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginCopyGreenChannelAllFramesNameD(IntPtr path, double redIntensity, double blueIntensity);
		/// <summary>
		/// Copy animation key color from the source animation to the target animation 
		/// for the given frame. Reference the source and target by id.
		/// EXPORT_API void PluginCopyKeyColor(int sourceAnimationId, int targetAnimationId, int frameId, int rzkey);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyKeyColor(int sourceAnimationId, int targetAnimationId, int frameId, int rzkey);
		/// <summary>
		/// Copy animation key color from the source animation to the target animation 
		/// for all frames. Reference the source and target by id.
		/// EXPORT_API void PluginCopyKeyColorAllFrames(int sourceAnimationId, int targetAnimationId, int rzkey);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyKeyColorAllFrames(int sourceAnimationId, int targetAnimationId, int rzkey);
		/// <summary>
		/// Copy animation key color from the source animation to the target animation 
		/// for all frames. Reference the source and target by name.
		/// EXPORT_API void PluginCopyKeyColorAllFramesName(const char* sourceAnimation, const char* targetAnimation, int rzkey);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyKeyColorAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation, int rzkey);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginCopyKeyColorAllFramesNameD(const char* sourceAnimation, const char* targetAnimation, double rzkey);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginCopyKeyColorAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double rzkey);
		/// <summary>
		/// Copy animation key color from the source animation to the target animation 
		/// for all frames, starting at the offset for the length of the source animation. 
		/// Source and target are referenced by id.
		/// EXPORT_API void PluginCopyKeyColorAllFramesOffset(int sourceAnimationId, int targetAnimationId, int rzkey, int offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyKeyColorAllFramesOffset(int sourceAnimationId, int targetAnimationId, int rzkey, int offset);
		/// <summary>
		/// Copy animation key color from the source animation to the target animation 
		/// for all frames, starting at the offset for the length of the source animation. 
		/// Source and target are referenced by name.
		/// EXPORT_API void PluginCopyKeyColorAllFramesOffsetName(const char* sourceAnimation, const char* targetAnimation, int rzkey, int offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyKeyColorAllFramesOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int rzkey, int offset);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginCopyKeyColorAllFramesOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double rzkey, double offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginCopyKeyColorAllFramesOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double rzkey, double offset);
		/// <summary>
		/// Copy animation key color from the source animation to the target animation 
		/// for the given frame.
		/// EXPORT_API void PluginCopyKeyColorName(const char* sourceAnimation, const char* targetAnimation, int frameId, int rzkey);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyKeyColorName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId, int rzkey);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginCopyKeyColorNameD(const char* sourceAnimation, const char* targetAnimation, double frameId, double rzkey);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginCopyKeyColorNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId, double rzkey);
		/// <summary>
		/// Copy animation color for a set of keys from the source animation to the 
		/// target animation for the given frame. Reference the source and target by 
		/// id.
		/// EXPORT_API void PluginCopyKeysColor(int sourceAnimationId, int targetAnimationId, int frameId, const int* keys, int size);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyKeysColor(int sourceAnimationId, int targetAnimationId, int frameId, int[] keys, int size);
		/// <summary>
		/// Copy animation color for a set of keys from the source animation to the 
		/// target animation for all frames. Reference the source and target by id. 
		///
		/// EXPORT_API void PluginCopyKeysColorAllFrames(int sourceAnimationId, int targetAnimationId, const int* keys, int size);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyKeysColorAllFrames(int sourceAnimationId, int targetAnimationId, int[] keys, int size);
		/// <summary>
		/// Copy animation color for a set of keys from the source animation to the 
		/// target animation for all frames. Reference the source and target by name. 
		///
		/// EXPORT_API void PluginCopyKeysColorAllFramesName(const char* sourceAnimation, const char* targetAnimation, const int* keys, int size);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyKeysColorAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation, int[] keys, int size);
		/// <summary>
		/// Copy animation color for a set of keys from the source animation to the 
		/// target animation for the given frame. Reference the source and target by 
		/// name.
		/// EXPORT_API void PluginCopyKeysColorName(const char* sourceAnimation, const char* targetAnimation, int frameId, const int* keys, int size);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyKeysColorName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId, int[] keys, int size);
		/// <summary>
		/// Copy animation color for a set of keys from the source animation to the 
		/// target animation from the source frame to the target frame. Reference the 
		/// source and target by id.
		/// EXPORT_API void PluginCopyKeysColorOffset(int sourceAnimationId, int targetAnimationId, int sourceFrameId, int targetFrameId, const int* keys, int size);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyKeysColorOffset(int sourceAnimationId, int targetAnimationId, int sourceFrameId, int targetFrameId, int[] keys, int size);
		/// <summary>
		/// Copy animation color for a set of keys from the source animation to the 
		/// target animation from the source frame to the target frame. Reference the 
		/// source and target by name.
		/// EXPORT_API void PluginCopyKeysColorOffsetName(const char* sourceAnimation, const char* targetAnimation, int sourceFrameId, int targetFrameId, const int* keys, int size);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyKeysColorOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int sourceFrameId, int targetFrameId, int[] keys, int size);
		/// <summary>
		/// Copy source animation to target animation for the given frame. Source and 
		/// target are referenced by id.
		/// EXPORT_API void PluginCopyNonZeroAllKeys(int sourceAnimationId, int targetAnimationId, int frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyNonZeroAllKeys(int sourceAnimationId, int targetAnimationId, int frameId);
		/// <summary>
		/// Copy nonzero colors from a source animation to a target animation for all 
		/// frames. Reference source and target by id.
		/// EXPORT_API void PluginCopyNonZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyNonZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
		/// <summary>
		/// Copy nonzero colors from a source animation to a target animation for all 
		/// frames. Reference source and target by name.
		/// EXPORT_API void PluginCopyNonZeroAllKeysAllFramesName(const char* sourceAnimation, const char* targetAnimation);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyNonZeroAllKeysAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginCopyNonZeroAllKeysAllFramesNameD(const char* sourceAnimation, const char* targetAnimation);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginCopyNonZeroAllKeysAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
		/// <summary>
		/// Copy nonzero colors from a source animation to a target animation for all 
		/// frames starting at the offset for the length of the source animation. The 
		/// source and target are referenced by id.
		/// EXPORT_API void PluginCopyNonZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyNonZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
		/// <summary>
		/// Copy nonzero colors from a source animation to a target animation for all 
		/// frames starting at the offset for the length of the source animation. The 
		/// source and target are referenced by name.
		/// EXPORT_API void PluginCopyNonZeroAllKeysAllFramesOffsetName(const char* sourceAnimation, const char* targetAnimation, int offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyNonZeroAllKeysAllFramesOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int offset);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginCopyNonZeroAllKeysAllFramesOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginCopyNonZeroAllKeysAllFramesOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double offset);
		/// <summary>
		/// Copy nonzero colors from source animation to target animation for the specified 
		/// frame. Source and target are referenced by id.
		/// EXPORT_API void PluginCopyNonZeroAllKeysName(const char* sourceAnimation, const char* targetAnimation, int frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyNonZeroAllKeysName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginCopyNonZeroAllKeysNameD(const char* sourceAnimation, const char* targetAnimation, double frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginCopyNonZeroAllKeysNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId);
		/// <summary>
		/// Copy nonzero colors from the source animation to the target animation from 
		/// the source frame to the target offset frame. Source and target are referenced 
		/// by id.
		/// EXPORT_API void PluginCopyNonZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyNonZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
		/// <summary>
		/// Copy nonzero colors from the source animation to the target animation from 
		/// the source frame to the target offset frame. Source and target are referenced 
		/// by name.
		/// EXPORT_API void PluginCopyNonZeroAllKeysOffsetName(const char* sourceAnimation, const char* targetAnimation, int frameId, int offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyNonZeroAllKeysOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId, int offset);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginCopyNonZeroAllKeysOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double frameId, double offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginCopyNonZeroAllKeysOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId, double offset);
		/// <summary>
		/// Copy animation key color from the source animation to the target animation 
		/// for the given frame where color is not zero.
		/// EXPORT_API void PluginCopyNonZeroKeyColor(int sourceAnimationId, int targetAnimationId, int frameId, int rzkey);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyNonZeroKeyColor(int sourceAnimationId, int targetAnimationId, int frameId, int rzkey);
		/// <summary>
		/// Copy animation key color from the source animation to the target animation 
		/// for the given frame where color is not zero.
		/// EXPORT_API void PluginCopyNonZeroKeyColorName(const char* sourceAnimation, const char* targetAnimation, int frameId, int rzkey);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyNonZeroKeyColorName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId, int rzkey);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginCopyNonZeroKeyColorNameD(const char* sourceAnimation, const char* targetAnimation, double frameId, double rzkey);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginCopyNonZeroKeyColorNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId, double rzkey);
		/// <summary>
		/// Copy nonzero colors from the source animation to the target animation where 
		/// the target color is nonzero for the specified frame. Source and target 
		/// are referenced by id.
		/// EXPORT_API void PluginCopyNonZeroTargetAllKeys(int sourceAnimationId, int targetAnimationId, int frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyNonZeroTargetAllKeys(int sourceAnimationId, int targetAnimationId, int frameId);
		/// <summary>
		/// Copy nonzero colors from the source animation to the target animation where 
		/// the target color is nonzero for all frames. Source and target are referenced 
		/// by id.
		/// EXPORT_API void PluginCopyNonZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyNonZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
		/// <summary>
		/// Copy nonzero colors from the source animation to the target animation where 
		/// the target color is nonzero for all frames. Source and target are referenced 
		/// by name.
		/// EXPORT_API void PluginCopyNonZeroTargetAllKeysAllFramesName(const char* sourceAnimation, const char* targetAnimation);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyNonZeroTargetAllKeysAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginCopyNonZeroTargetAllKeysAllFramesNameD(const char* sourceAnimation, const char* targetAnimation);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginCopyNonZeroTargetAllKeysAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
		/// <summary>
		/// Copy nonzero colors from the source animation to the target animation where 
		/// the target color is nonzero for all frames. Source and target are referenced 
		/// by name.
		/// EXPORT_API void PluginCopyNonZeroTargetAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyNonZeroTargetAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
		/// <summary>
		/// Copy nonzero colors from the source animation to the target animation where 
		/// the target color is nonzero for all frames starting at the target offset 
		/// for the length of the source animation. Source and target animations are 
		/// referenced by name.
		/// EXPORT_API void PluginCopyNonZeroTargetAllKeysAllFramesOffsetName(const char* sourceAnimation, const char* targetAnimation, int offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyNonZeroTargetAllKeysAllFramesOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int offset);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginCopyNonZeroTargetAllKeysAllFramesOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginCopyNonZeroTargetAllKeysAllFramesOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double offset);
		/// <summary>
		/// Copy nonzero colors from the source animation to the target animation where 
		/// the target color is nonzero for the specified frame. The source and target 
		/// are referenced by name.
		/// EXPORT_API void PluginCopyNonZeroTargetAllKeysName(const char* sourceAnimation, const char* targetAnimation, int frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyNonZeroTargetAllKeysName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginCopyNonZeroTargetAllKeysNameD(const char* sourceAnimation, const char* targetAnimation, double frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginCopyNonZeroTargetAllKeysNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId);
		/// <summary>
		/// Copy nonzero colors from the source animation to the target animation where 
		/// the target color is nonzero for the specified source frame and target offset 
		/// frame. The source and target are referenced by id.
		/// EXPORT_API void PluginCopyNonZeroTargetAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyNonZeroTargetAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
		/// <summary>
		/// Copy nonzero colors from the source animation to the target animation where 
		/// the target color is nonzero for the specified source frame and target offset 
		/// frame. The source and target are referenced by name.
		/// EXPORT_API void PluginCopyNonZeroTargetAllKeysOffsetName(const char* sourceAnimation, const char* targetAnimation, int frameId, int offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyNonZeroTargetAllKeysOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId, int offset);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginCopyNonZeroTargetAllKeysOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double frameId, double offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginCopyNonZeroTargetAllKeysOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId, double offset);
		/// <summary>
		/// Copy nonzero colors from the source animation to the target animation where 
		/// the target color is zero for all frames. Source and target are referenced 
		/// by id.
		/// EXPORT_API void PluginCopyNonZeroTargetZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyNonZeroTargetZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
		/// <summary>
		/// Copy nonzero colors from the source animation to the target animation where 
		/// the target color is zero for all frames. Source and target are referenced 
		/// by name.
		/// EXPORT_API void PluginCopyNonZeroTargetZeroAllKeysAllFramesName(const char* sourceAnimation, const char* targetAnimation);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyNonZeroTargetZeroAllKeysAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginCopyNonZeroTargetZeroAllKeysAllFramesNameD(const char* sourceAnimation, const char* targetAnimation);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginCopyNonZeroTargetZeroAllKeysAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
		/// <summary>
		/// Copy red channel to other channels for all frames. Intensity range is 0.0 
		/// to 1.0. Reference the animation by id.
		/// EXPORT_API void PluginCopyRedChannelAllFrames(int animationId, float greenIntensity, float blueIntensity);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyRedChannelAllFrames(int animationId, float greenIntensity, float blueIntensity);
		/// <summary>
		/// Copy green channel to other channels for all frames. Intensity range is 
		/// 0.0 to 1.0. Reference the animation by name.
		/// EXPORT_API void PluginCopyRedChannelAllFramesName(const char* path, float greenIntensity, float blueIntensity);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyRedChannelAllFramesName(IntPtr path, float greenIntensity, float blueIntensity);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginCopyRedChannelAllFramesNameD(const char* path, double greenIntensity, double blueIntensity);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginCopyRedChannelAllFramesNameD(IntPtr path, double greenIntensity, double blueIntensity);
		/// <summary>
		/// Copy zero colors from source animation to target animation for the frame. 
		/// Source and target are referenced by id.
		/// EXPORT_API void PluginCopyZeroAllKeys(int sourceAnimationId, int targetAnimationId, int frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyZeroAllKeys(int sourceAnimationId, int targetAnimationId, int frameId);
		/// <summary>
		/// Copy zero colors from source animation to target animation for all frames. 
		/// Source and target are referenced by id.
		/// EXPORT_API void PluginCopyZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
		/// <summary>
		/// Copy zero colors from source animation to target animation for all frames. 
		/// Source and target are referenced by name.
		/// EXPORT_API void PluginCopyZeroAllKeysAllFramesName(const char* sourceAnimation, const char* targetAnimation);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyZeroAllKeysAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginCopyZeroAllKeysAllFramesNameD(const char* sourceAnimation, const char* targetAnimation);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginCopyZeroAllKeysAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
		/// <summary>
		/// Copy zero colors from source animation to target animation for all frames 
		/// starting at the target offset for the length of the source animation. Source 
		/// and target are referenced by id.
		/// EXPORT_API void PluginCopyZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
		/// <summary>
		/// Copy zero colors from source animation to target animation for all frames 
		/// starting at the target offset for the length of the source animation. Source 
		/// and target are referenced by name.
		/// EXPORT_API void PluginCopyZeroAllKeysAllFramesOffsetName(const char* sourceAnimation, const char* targetAnimation, int offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyZeroAllKeysAllFramesOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int offset);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginCopyZeroAllKeysAllFramesOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginCopyZeroAllKeysAllFramesOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double offset);
		/// <summary>
		/// Copy zero colors from source animation to target animation for the frame. 
		/// Source and target are referenced by name.
		/// EXPORT_API void PluginCopyZeroAllKeysName(const char* sourceAnimation, const char* targetAnimation, int frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyZeroAllKeysName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId);
		/// <summary>
		/// Copy zero colors from source animation to target animation for the frame 
		/// id starting at the target offset for the length of the source animation. 
		/// Source and target are referenced by id.
		/// EXPORT_API void PluginCopyZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
		/// <summary>
		/// Copy zero colors from source animation to target animation for the frame 
		/// id starting at the target offset for the length of the source animation. 
		/// Source and target are referenced by name.
		/// EXPORT_API void PluginCopyZeroAllKeysOffsetName(const char* sourceAnimation, const char* targetAnimation, int frameId, int offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyZeroAllKeysOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId, int offset);
		/// <summary>
		/// Copy zero key color from source animation to target animation for the specified 
		/// frame. Source and target are referenced by id.
		/// EXPORT_API void PluginCopyZeroKeyColor(int sourceAnimationId, int targetAnimationId, int frameId, int rzkey);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyZeroKeyColor(int sourceAnimationId, int targetAnimationId, int frameId, int rzkey);
		/// <summary>
		/// Copy zero key color from source animation to target animation for the specified 
		/// frame. Source and target are referenced by name.
		/// EXPORT_API void PluginCopyZeroKeyColorName(const char* sourceAnimation, const char* targetAnimation, int frameId, int rzkey);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyZeroKeyColorName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId, int rzkey);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginCopyZeroKeyColorNameD(const char* sourceAnimation, const char* targetAnimation, double frameId, double rzkey);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginCopyZeroKeyColorNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId, double rzkey);
		/// <summary>
		/// Copy nonzero color from source animation to target animation where target 
		/// is zero for the frame. Source and target are referenced by id.
		/// EXPORT_API void PluginCopyZeroTargetAllKeys(int sourceAnimationId, int targetAnimationId, int frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyZeroTargetAllKeys(int sourceAnimationId, int targetAnimationId, int frameId);
		/// <summary>
		/// Copy nonzero color from source animation to target animation where target 
		/// is zero for all frames. Source and target are referenced by id.
		/// EXPORT_API void PluginCopyZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
		/// <summary>
		/// Copy nonzero color from source animation to target animation where target 
		/// is zero for all frames. Source and target are referenced by name.
		/// EXPORT_API void PluginCopyZeroTargetAllKeysAllFramesName(const char* sourceAnimation, const char* targetAnimation);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyZeroTargetAllKeysAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginCopyZeroTargetAllKeysAllFramesNameD(const char* sourceAnimation, const char* targetAnimation);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginCopyZeroTargetAllKeysAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
		/// <summary>
		/// Copy nonzero color from source animation to target animation where target 
		/// is zero for the frame. Source and target are referenced by name.
		/// EXPORT_API void PluginCopyZeroTargetAllKeysName(const char* sourceAnimation, const char* targetAnimation, int frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCopyZeroTargetAllKeysName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId);
		/// <summary>
		/// Direct access to low level API.
		/// EXPORT_API RZRESULT PluginCoreCreateChromaLinkEffect(ChromaSDK::ChromaLink::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID* pEffectId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginCoreCreateChromaLinkEffect(int effect, IntPtr pParam, out Guid pEffectId);
		/// <summary>
		/// Direct access to low level API.
		/// EXPORT_API RZRESULT PluginCoreCreateEffect(RZDEVICEID DeviceId, ChromaSDK::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID* pEffectId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginCoreCreateEffect(Guid deviceId, int effect, IntPtr pParam, out Guid pEffectId);
		/// <summary>
		/// Direct access to low level API.
		/// EXPORT_API RZRESULT PluginCoreCreateHeadsetEffect(ChromaSDK::Headset::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID* pEffectId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginCoreCreateHeadsetEffect(int effect, IntPtr pParam, out Guid pEffectId);
		/// <summary>
		/// Direct access to low level API.
		/// EXPORT_API RZRESULT PluginCoreCreateKeyboardEffect(ChromaSDK::Keyboard::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID* pEffectId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginCoreCreateKeyboardEffect(int effect, IntPtr pParam, out Guid pEffectId);
		/// <summary>
		/// Direct access to low level API.
		/// EXPORT_API RZRESULT PluginCoreCreateKeypadEffect(ChromaSDK::Keypad::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID* pEffectId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginCoreCreateKeypadEffect(int effect, IntPtr pParam, out Guid pEffectId);
		/// <summary>
		/// Direct access to low level API.
		/// EXPORT_API RZRESULT PluginCoreCreateMouseEffect(ChromaSDK::Mouse::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID* pEffectId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginCoreCreateMouseEffect(int effect, IntPtr pParam, out Guid pEffectId);
		/// <summary>
		/// Direct access to low level API.
		/// EXPORT_API RZRESULT PluginCoreCreateMousepadEffect(ChromaSDK::Mousepad::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID* pEffectId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginCoreCreateMousepadEffect(int effect, IntPtr pParam, out Guid pEffectId);
		/// <summary>
		/// Direct access to low level API.
		/// EXPORT_API RZRESULT PluginCoreDeleteEffect(RZEFFECTID EffectId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginCoreDeleteEffect(Guid effectId);
		/// <summary>
		/// Direct access to low level API.
		/// EXPORT_API RZRESULT PluginCoreInit();
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginCoreInit();
		/// <summary>
		/// Direct access to low level API.
		/// EXPORT_API RZRESULT PluginCoreInitSDK(ChromaSDK::APPINFOTYPE* AppInfo);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginCoreInitSDK(ref ChromaSDK.APPINFOTYPE appInfo);
		/// <summary>
		/// Direct access to low level API.
		/// EXPORT_API RZRESULT PluginCoreQueryDevice(RZDEVICEID DeviceId, ChromaSDK::DEVICE_INFO_TYPE& DeviceInfo);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginCoreQueryDevice(Guid deviceId, out DEVICE_INFO_TYPE deviceInfo);
		/// <summary>
		/// Direct access to low level API.
		/// EXPORT_API RZRESULT PluginCoreSetEffect(RZEFFECTID EffectId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginCoreSetEffect(Guid effectId);
		/// <summary>
		/// Begin broadcasting Chroma RGB data using the stored stream key as the endpoint. 
		/// Intended for Cloud Gaming Platforms,  restore the streaming key when the 
		/// game instance is launched to continue streaming.  streamId is a null terminated 
		/// string  streamKey is a null terminated string  StreamGetStatus() should 
		/// return the READY status to use this method.
		/// EXPORT_API bool PluginCoreStreamBroadcast(const char* streamId, const char* streamKey);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern bool PluginCoreStreamBroadcast(IntPtr streamId, IntPtr streamKey);
		/// <summary>
		/// End broadcasting Chroma RGB data.  StreamGetStatus() should return the BROADCASTING 
		/// status to use this method.
		/// EXPORT_API bool PluginCoreStreamBroadcastEnd();
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern bool PluginCoreStreamBroadcastEnd();
		/// <summary>
		/// shortcode: Pass the address of a preallocated character buffer to get the 
		/// streaming auth code. The buffer should have a minimum length of 6.  length: 
		/// Length will return as zero if the streaming auth code could not be obtained. 
		/// If length is greater than zero, it will be the length of the returned streaming 
		/// auth code.  Once you have the shortcode, it should be shown to the user 
		/// so they can associate the stream with their Razer ID  StreamGetStatus() 
		/// should return the READY status before invoking this method. platform: is 
		/// the null terminated string that identifies the source of the stream: { 
		/// GEFORCE_NOW, LUNA, STADIA, GAME_PASS } title: is the null terminated string 
		/// that identifies the application or game.
		/// EXPORT_API void PluginCoreStreamGetAuthShortcode(char* shortcode, unsigned char* length, const wchar_t* platform, const wchar_t* title);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCoreStreamGetAuthShortcode(IntPtr shortcode, out byte length, IntPtr platform, IntPtr title);
		/// <summary>
		/// focus: Pass the address of a preallocated character buffer to get the stream 
		/// focus. The buffer should have a length of 48  length: Length will return 
		/// as zero if the stream focus could not be obtained. If length is greater 
		/// than zero, it will be the length of the returned stream focus.
		/// EXPORT_API bool PluginCoreStreamGetFocus(char* focus, unsigned char* length);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern bool PluginCoreStreamGetFocus(IntPtr focus, out byte length);
		/// <summary>
		/// Intended for Cloud Gaming Platforms, store the stream id to persist in user 
		/// preferences to continue streaming if the game is suspended or closed. shortcode: 
		/// The shortcode is a null terminated string. Use the shortcode that authorized 
		/// the stream to obtain the stream id.  streamId should be a preallocated 
		/// buffer to get the stream key. The buffer should have a length of 48.  length: 
		/// Length will return zero if the key could not be obtained. If the length 
		/// is greater than zero, it will be the length of the returned streaming id. 
		/// Retrieve the stream id after authorizing the shortcode. The authorization 
		/// window will expire in 5 minutes. Be sure to save the stream key before 
		/// the window expires. StreamGetStatus() should return the READY status to 
		/// use this method.
		/// EXPORT_API void PluginCoreStreamGetId(const char* shortcode, char* streamId, unsigned char* length);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCoreStreamGetId(IntPtr shortcode, IntPtr streamId, out byte length);
		/// <summary>
		/// Intended for Cloud Gaming Platforms, store the streaming key to persist 
		/// in user preferences to continue streaming if the game is suspended or closed. 
		/// shortcode: The shortcode is a null terminated string. Use the shortcode 
		/// that authorized the stream to obtain the stream key.  If the status is 
		/// in the BROADCASTING or WATCHING state, passing a NULL shortcode will return 
		/// the active streamId.  streamKey should be a preallocated buffer to get 
		/// the stream key. The buffer should have a length of 48.  length: Length 
		/// will return zero if the key could not be obtained. If the length is greater 
		/// than zero, it will be the length of the returned streaming key.  Retrieve 
		/// the stream key after authorizing the shortcode. The authorization window 
		/// will expire in 5 minutes. Be sure to save the stream key before the window 
		/// expires.  StreamGetStatus() should return the READY status to use this 
		/// method.
		/// EXPORT_API void PluginCoreStreamGetKey(const char* shortcode, char* streamKey, unsigned char* length);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginCoreStreamGetKey(IntPtr shortcode, IntPtr streamKey, out byte length);
		/// <summary>
		/// Returns StreamStatus, the current status of the service
		/// EXPORT_API ChromaSDK::Stream::StreamStatusType PluginCoreStreamGetStatus();
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern ChromaSDK.Stream.StreamStatusType PluginCoreStreamGetStatus();
		/// <summary>
		/// Convert StreamStatusType to a printable string
		/// EXPORT_API const char* PluginCoreStreamGetStatusString(ChromaSDK::Stream::StreamStatusType status);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr PluginCoreStreamGetStatusString(ChromaSDK.Stream.StreamStatusType status);
		/// <summary>
		/// This prevents the stream id and stream key from being obtained through the 
		/// shortcode. This closes the auth window.  shortcode is a null terminated 
		/// string.  StreamGetStatus() should return the READY status to use this method. 
		/// returns success when shortcode has been released
		/// EXPORT_API bool PluginCoreStreamReleaseShortcode(const char* shortcode);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern bool PluginCoreStreamReleaseShortcode(IntPtr shortcode);
		/// <summary>
		/// The focus is a null terminated string. Set the focus identifer for the application 
		/// designated to automatically change the streaming state.  Returns true on 
		/// success.
		/// EXPORT_API bool PluginCoreStreamSetFocus(const char* focus);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern bool PluginCoreStreamSetFocus(IntPtr focus);
		/// <summary>
		/// Returns true if the Chroma streaming is supported. If false is returned, 
		/// avoid calling stream methods.
		/// EXPORT_API bool PluginCoreStreamSupportsStreaming();
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern bool PluginCoreStreamSupportsStreaming();
		/// <summary>
		/// Begin watching the Chroma RGB data using streamID parameter.  streamId is 
		/// a null terminated string.  StreamGetStatus() should return the READY status 
		/// to use this method.
		/// EXPORT_API bool PluginCoreStreamWatch(const char* streamId, unsigned long long timestamp);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern bool PluginCoreStreamWatch(IntPtr streamId, ulong timestamp);
		/// <summary>
		/// End watching Chroma RGB data stream.  StreamGetStatus() should return the 
		/// WATCHING status to use this method.
		/// EXPORT_API bool PluginCoreStreamWatchEnd();
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern bool PluginCoreStreamWatchEnd();
		/// <summary>
		/// Direct access to low level API.
		/// EXPORT_API RZRESULT PluginCoreUnInit();
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginCoreUnInit();
		/// <summary>
		/// Creates a `Chroma` animation at the given path. The `deviceType` parameter 
		/// uses `EChromaSDKDeviceTypeEnum` as an integer. The `device` parameter uses 
		/// `EChromaSDKDevice1DEnum` or `EChromaSDKDevice2DEnum` as an integer, respective 
		/// to the `deviceType`. Returns the animation id upon success. Returns negative 
		/// one upon failure. Saves a `Chroma` animation file with the `.chroma` extension 
		/// at the given path. Returns the animation id upon success. Returns negative 
		/// one upon failure.
		/// EXPORT_API int PluginCreateAnimation(const char* path, int deviceType, int device);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginCreateAnimation(IntPtr path, int deviceType, int device);
		/// <summary>
		/// Creates a `Chroma` animation in memory without creating a file. The `deviceType` 
		/// parameter uses `EChromaSDKDeviceTypeEnum` as an integer. The `device` parameter 
		/// uses `EChromaSDKDevice1DEnum` or `EChromaSDKDevice2DEnum` as an integer, 
		/// respective to the `deviceType`. Returns the animation id upon success. 
		/// Returns negative one upon failure. Returns the animation id upon success. 
		/// Returns negative one upon failure.
		/// EXPORT_API int PluginCreateAnimationInMemory(int deviceType, int device);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginCreateAnimationInMemory(int deviceType, int device);
		/// <summary>
		/// Create a device specific effect.
		/// EXPORT_API RZRESULT PluginCreateEffect(RZDEVICEID deviceId, ChromaSDK::EFFECT_TYPE effect, int* colors, int size, ChromaSDK::FChromaSDKGuid* effectId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginCreateEffect(Guid deviceId, int effect, int[] colors, int size, out FChromaSDKGuid effectId);
		/// <summary>
		/// Delete an effect given the effect id.
		/// EXPORT_API RZRESULT PluginDeleteEffect(const ChromaSDK::FChromaSDKGuid& effectId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginDeleteEffect(Guid effectId);
		/// <summary>
		/// Duplicate the first animation frame so that the animation length matches 
		/// the frame count. Animation is referenced by id.
		/// EXPORT_API void PluginDuplicateFirstFrame(int animationId, int frameCount);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginDuplicateFirstFrame(int animationId, int frameCount);
		/// <summary>
		/// Duplicate the first animation frame so that the animation length matches 
		/// the frame count. Animation is referenced by name.
		/// EXPORT_API void PluginDuplicateFirstFrameName(const char* path, int frameCount);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginDuplicateFirstFrameName(IntPtr path, int frameCount);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginDuplicateFirstFrameNameD(const char* path, double frameCount);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginDuplicateFirstFrameNameD(IntPtr path, double frameCount);
		/// <summary>
		/// Duplicate all the frames of the animation to double the animation length. 
		/// Frame 1 becomes frame 1 and 2. Frame 2 becomes frame 3 and 4. And so on. 
		/// The animation is referenced by id.
		/// EXPORT_API void PluginDuplicateFrames(int animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginDuplicateFrames(int animationId);
		/// <summary>
		/// Duplicate all the frames of the animation to double the animation length. 
		/// Frame 1 becomes frame 1 and 2. Frame 2 becomes frame 3 and 4. And so on. 
		/// The animation is referenced by name.
		/// EXPORT_API void PluginDuplicateFramesName(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginDuplicateFramesName(IntPtr path);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginDuplicateFramesNameD(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginDuplicateFramesNameD(IntPtr path);
		/// <summary>
		/// Duplicate all the animation frames in reverse so that the animation plays 
		/// forwards and backwards. Animation is referenced by id.
		/// EXPORT_API void PluginDuplicateMirrorFrames(int animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginDuplicateMirrorFrames(int animationId);
		/// <summary>
		/// Duplicate all the animation frames in reverse so that the animation plays 
		/// forwards and backwards. Animation is referenced by name.
		/// EXPORT_API void PluginDuplicateMirrorFramesName(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginDuplicateMirrorFramesName(IntPtr path);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginDuplicateMirrorFramesNameD(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginDuplicateMirrorFramesNameD(IntPtr path);
		/// <summary>
		/// Fade the animation to black starting at the fade frame index to the end 
		/// of the animation. Animation is referenced by id.
		/// EXPORT_API void PluginFadeEndFrames(int animationId, int fade);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFadeEndFrames(int animationId, int fade);
		/// <summary>
		/// Fade the animation to black starting at the fade frame index to the end 
		/// of the animation. Animation is referenced by name.
		/// EXPORT_API void PluginFadeEndFramesName(const char* path, int fade);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFadeEndFramesName(IntPtr path, int fade);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginFadeEndFramesNameD(const char* path, double fade);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginFadeEndFramesNameD(IntPtr path, double fade);
		/// <summary>
		/// Fade the animation from black to full color starting at 0 to the fade frame 
		/// index. Animation is referenced by id.
		/// EXPORT_API void PluginFadeStartFrames(int animationId, int fade);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFadeStartFrames(int animationId, int fade);
		/// <summary>
		/// Fade the animation from black to full color starting at 0 to the fade frame 
		/// index. Animation is referenced by name.
		/// EXPORT_API void PluginFadeStartFramesName(const char* path, int fade);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFadeStartFramesName(IntPtr path, int fade);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginFadeStartFramesNameD(const char* path, double fade);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginFadeStartFramesNameD(IntPtr path, double fade);
		/// <summary>
		/// Set the RGB value for all colors in the specified frame. Animation is referenced 
		/// by id.
		/// EXPORT_API void PluginFillColor(int animationId, int frameId, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillColor(int animationId, int frameId, int color);
		/// <summary>
		/// Set the RGB value for all colors for all frames. Animation is referenced 
		/// by id.
		/// EXPORT_API void PluginFillColorAllFrames(int animationId, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillColorAllFrames(int animationId, int color);
		/// <summary>
		/// Set the RGB value for all colors for all frames. Animation is referenced 
		/// by name.
		/// EXPORT_API void PluginFillColorAllFramesName(const char* path, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillColorAllFramesName(IntPtr path, int color);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginFillColorAllFramesNameD(const char* path, double color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginFillColorAllFramesNameD(IntPtr path, double color);
		/// <summary>
		/// Set the RGB value for all colors for all frames. Use the range of 0 to 255 
		/// for red, green, and blue parameters. Animation is referenced by id.
		/// EXPORT_API void PluginFillColorAllFramesRGB(int animationId, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillColorAllFramesRGB(int animationId, int red, int green, int blue);
		/// <summary>
		/// Set the RGB value for all colors for all frames. Use the range of 0 to 255 
		/// for red, green, and blue parameters. Animation is referenced by name.
		/// EXPORT_API void PluginFillColorAllFramesRGBName(const char* path, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillColorAllFramesRGBName(IntPtr path, int red, int green, int blue);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginFillColorAllFramesRGBNameD(const char* path, double red, double green, double blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginFillColorAllFramesRGBNameD(IntPtr path, double red, double green, double blue);
		/// <summary>
		/// Set the RGB value for all colors in the specified frame. Animation is referenced 
		/// by name.
		/// EXPORT_API void PluginFillColorName(const char* path, int frameId, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillColorName(IntPtr path, int frameId, int color);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginFillColorNameD(const char* path, double frameId, double color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginFillColorNameD(IntPtr path, double frameId, double color);
		/// <summary>
		/// Set the RGB value for all colors in the specified frame. Animation is referenced 
		/// by id.
		/// EXPORT_API void PluginFillColorRGB(int animationId, int frameId, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillColorRGB(int animationId, int frameId, int red, int green, int blue);
		/// <summary>
		/// Set the RGB value for all colors in the specified frame. Animation is referenced 
		/// by name.
		/// EXPORT_API void PluginFillColorRGBName(const char* path, int frameId, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillColorRGBName(IntPtr path, int frameId, int red, int green, int blue);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginFillColorRGBNameD(const char* path, double frameId, double red, double green, double blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginFillColorRGBNameD(IntPtr path, double frameId, double red, double green, double blue);
		/// <summary>
		/// This method will only update colors in the animation that are not already 
		/// set to black. Set the RGB value for a subset of colors in the specified 
		/// frame. Animation is referenced by id.
		/// EXPORT_API void PluginFillNonZeroColor(int animationId, int frameId, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillNonZeroColor(int animationId, int frameId, int color);
		/// <summary>
		/// This method will only update colors in the animation that are not already 
		/// set to black. Set the RGB value for a subset of colors for all frames. 
		/// Animation is referenced by id.
		/// EXPORT_API void PluginFillNonZeroColorAllFrames(int animationId, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillNonZeroColorAllFrames(int animationId, int color);
		/// <summary>
		/// This method will only update colors in the animation that are not already 
		/// set to black. Set the RGB value for a subset of colors for all frames. 
		/// Animation is referenced by name.
		/// EXPORT_API void PluginFillNonZeroColorAllFramesName(const char* path, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillNonZeroColorAllFramesName(IntPtr path, int color);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginFillNonZeroColorAllFramesNameD(const char* path, double color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginFillNonZeroColorAllFramesNameD(IntPtr path, double color);
		/// <summary>
		/// This method will only update colors in the animation that are not already 
		/// set to black. Set the RGB value for a subset of colors for all frames. 
		/// Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		/// is referenced by id.
		/// EXPORT_API void PluginFillNonZeroColorAllFramesRGB(int animationId, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillNonZeroColorAllFramesRGB(int animationId, int red, int green, int blue);
		/// <summary>
		/// This method will only update colors in the animation that are not already 
		/// set to black. Set the RGB value for a subset of colors for all frames. 
		/// Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		/// is referenced by name.
		/// EXPORT_API void PluginFillNonZeroColorAllFramesRGBName(const char* path, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillNonZeroColorAllFramesRGBName(IntPtr path, int red, int green, int blue);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginFillNonZeroColorAllFramesRGBNameD(const char* path, double red, double green, double blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginFillNonZeroColorAllFramesRGBNameD(IntPtr path, double red, double green, double blue);
		/// <summary>
		/// This method will only update colors in the animation that are not already 
		/// set to black. Set the RGB value for a subset of colors in the specified 
		/// frame. Animation is referenced by name.
		/// EXPORT_API void PluginFillNonZeroColorName(const char* path, int frameId, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillNonZeroColorName(IntPtr path, int frameId, int color);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginFillNonZeroColorNameD(const char* path, double frameId, double color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginFillNonZeroColorNameD(IntPtr path, double frameId, double color);
		/// <summary>
		/// This method will only update colors in the animation that are not already 
		/// set to black. Set the RGB value for a subset of colors in the specified 
		/// frame. Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		/// is referenced by id.
		/// EXPORT_API void PluginFillNonZeroColorRGB(int animationId, int frameId, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillNonZeroColorRGB(int animationId, int frameId, int red, int green, int blue);
		/// <summary>
		/// This method will only update colors in the animation that are not already 
		/// set to black. Set the RGB value for a subset of colors in the specified 
		/// frame. Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		/// is referenced by name.
		/// EXPORT_API void PluginFillNonZeroColorRGBName(const char* path, int frameId, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillNonZeroColorRGBName(IntPtr path, int frameId, int red, int green, int blue);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginFillNonZeroColorRGBNameD(const char* path, double frameId, double red, double green, double blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginFillNonZeroColorRGBNameD(IntPtr path, double frameId, double red, double green, double blue);
		/// <summary>
		/// Fill the frame with random RGB values for the given frame. Animation is 
		/// referenced by id.
		/// EXPORT_API void PluginFillRandomColors(int animationId, int frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillRandomColors(int animationId, int frameId);
		/// <summary>
		/// Fill the frame with random RGB values for all frames. Animation is referenced 
		/// by id.
		/// EXPORT_API void PluginFillRandomColorsAllFrames(int animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillRandomColorsAllFrames(int animationId);
		/// <summary>
		/// Fill the frame with random RGB values for all frames. Animation is referenced 
		/// by name.
		/// EXPORT_API void PluginFillRandomColorsAllFramesName(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillRandomColorsAllFramesName(IntPtr path);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginFillRandomColorsAllFramesNameD(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginFillRandomColorsAllFramesNameD(IntPtr path);
		/// <summary>
		/// Fill the frame with random black and white values for the specified frame. 
		/// Animation is referenced by id.
		/// EXPORT_API void PluginFillRandomColorsBlackAndWhite(int animationId, int frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillRandomColorsBlackAndWhite(int animationId, int frameId);
		/// <summary>
		/// Fill the frame with random black and white values for all frames. Animation 
		/// is referenced by id.
		/// EXPORT_API void PluginFillRandomColorsBlackAndWhiteAllFrames(int animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillRandomColorsBlackAndWhiteAllFrames(int animationId);
		/// <summary>
		/// Fill the frame with random black and white values for all frames. Animation 
		/// is referenced by name.
		/// EXPORT_API void PluginFillRandomColorsBlackAndWhiteAllFramesName(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillRandomColorsBlackAndWhiteAllFramesName(IntPtr path);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginFillRandomColorsBlackAndWhiteAllFramesNameD(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginFillRandomColorsBlackAndWhiteAllFramesNameD(IntPtr path);
		/// <summary>
		/// Fill the frame with random black and white values for the specified frame. 
		/// Animation is referenced by name.
		/// EXPORT_API void PluginFillRandomColorsBlackAndWhiteName(const char* path, int frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillRandomColorsBlackAndWhiteName(IntPtr path, int frameId);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginFillRandomColorsBlackAndWhiteNameD(const char* path, double frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginFillRandomColorsBlackAndWhiteNameD(IntPtr path, double frameId);
		/// <summary>
		/// Fill the frame with random RGB values for the given frame. Animation is 
		/// referenced by name.
		/// EXPORT_API void PluginFillRandomColorsName(const char* path, int frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillRandomColorsName(IntPtr path, int frameId);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginFillRandomColorsNameD(const char* path, double frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginFillRandomColorsNameD(IntPtr path, double frameId);
		/// <summary>
		/// Fill the specified frame with RGB color where the animation color is less 
		/// than the RGB threshold. Animation is referenced by id.
		/// EXPORT_API void PluginFillThresholdColors(int animationId, int frameId, int threshold, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillThresholdColors(int animationId, int frameId, int threshold, int color);
		/// <summary>
		/// Fill all frames with RGB color where the animation color is less than the 
		/// RGB threshold. Animation is referenced by id.
		/// EXPORT_API void PluginFillThresholdColorsAllFrames(int animationId, int threshold, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillThresholdColorsAllFrames(int animationId, int threshold, int color);
		/// <summary>
		/// Fill all frames with RGB color where the animation color is less than the 
		/// RGB threshold. Animation is referenced by name.
		/// EXPORT_API void PluginFillThresholdColorsAllFramesName(const char* path, int threshold, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillThresholdColorsAllFramesName(IntPtr path, int threshold, int color);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginFillThresholdColorsAllFramesNameD(const char* path, double threshold, double color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginFillThresholdColorsAllFramesNameD(IntPtr path, double threshold, double color);
		/// <summary>
		/// Fill all frames with RGB color where the animation color is less than the 
		/// threshold. Animation is referenced by id.
		/// EXPORT_API void PluginFillThresholdColorsAllFramesRGB(int animationId, int threshold, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillThresholdColorsAllFramesRGB(int animationId, int threshold, int red, int green, int blue);
		/// <summary>
		/// Fill all frames with RGB color where the animation color is less than the 
		/// threshold. Animation is referenced by name.
		/// EXPORT_API void PluginFillThresholdColorsAllFramesRGBName(const char* path, int threshold, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillThresholdColorsAllFramesRGBName(IntPtr path, int threshold, int red, int green, int blue);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginFillThresholdColorsAllFramesRGBNameD(const char* path, double threshold, double red, double green, double blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginFillThresholdColorsAllFramesRGBNameD(IntPtr path, double threshold, double red, double green, double blue);
		/// <summary>
		/// Fill all frames with the min RGB color where the animation color is less 
		/// than the min threshold AND with the max RGB color where the animation is 
		/// more than the max threshold. Animation is referenced by id.
		/// EXPORT_API void PluginFillThresholdColorsMinMaxAllFramesRGB(int animationId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillThresholdColorsMinMaxAllFramesRGB(int animationId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue);
		/// <summary>
		/// Fill all frames with the min RGB color where the animation color is less 
		/// than the min threshold AND with the max RGB color where the animation is 
		/// more than the max threshold. Animation is referenced by name.
		/// EXPORT_API void PluginFillThresholdColorsMinMaxAllFramesRGBName(const char* path, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillThresholdColorsMinMaxAllFramesRGBName(IntPtr path, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginFillThresholdColorsMinMaxAllFramesRGBNameD(const char* path, double minThreshold, double minRed, double minGreen, double minBlue, double maxThreshold, double maxRed, double maxGreen, double maxBlue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginFillThresholdColorsMinMaxAllFramesRGBNameD(IntPtr path, double minThreshold, double minRed, double minGreen, double minBlue, double maxThreshold, double maxRed, double maxGreen, double maxBlue);
		/// <summary>
		/// Fill the specified frame with the min RGB color where the animation color 
		/// is less than the min threshold AND with the max RGB color where the animation 
		/// is more than the max threshold. Animation is referenced by id.
		/// EXPORT_API void PluginFillThresholdColorsMinMaxRGB(int animationId, int frameId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillThresholdColorsMinMaxRGB(int animationId, int frameId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue);
		/// <summary>
		/// Fill the specified frame with the min RGB color where the animation color 
		/// is less than the min threshold AND with the max RGB color where the animation 
		/// is more than the max threshold. Animation is referenced by name.
		/// EXPORT_API void PluginFillThresholdColorsMinMaxRGBName(const char* path, int frameId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillThresholdColorsMinMaxRGBName(IntPtr path, int frameId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginFillThresholdColorsMinMaxRGBNameD(const char* path, double frameId, double minThreshold, double minRed, double minGreen, double minBlue, double maxThreshold, double maxRed, double maxGreen, double maxBlue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginFillThresholdColorsMinMaxRGBNameD(IntPtr path, double frameId, double minThreshold, double minRed, double minGreen, double minBlue, double maxThreshold, double maxRed, double maxGreen, double maxBlue);
		/// <summary>
		/// Fill the specified frame with RGB color where the animation color is less 
		/// than the RGB threshold. Animation is referenced by name.
		/// EXPORT_API void PluginFillThresholdColorsName(const char* path, int frameId, int threshold, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillThresholdColorsName(IntPtr path, int frameId, int threshold, int color);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginFillThresholdColorsNameD(const char* path, double frameId, double threshold, double color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginFillThresholdColorsNameD(IntPtr path, double frameId, double threshold, double color);
		/// <summary>
		/// Fill the specified frame with RGB color where the animation color is less 
		/// than the RGB threshold. Animation is referenced by id.
		/// EXPORT_API void PluginFillThresholdColorsRGB(int animationId, int frameId, int threshold, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillThresholdColorsRGB(int animationId, int frameId, int threshold, int red, int green, int blue);
		/// <summary>
		/// Fill the specified frame with RGB color where the animation color is less 
		/// than the RGB threshold. Animation is referenced by name.
		/// EXPORT_API void PluginFillThresholdColorsRGBName(const char* path, int frameId, int threshold, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillThresholdColorsRGBName(IntPtr path, int frameId, int threshold, int red, int green, int blue);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginFillThresholdColorsRGBNameD(const char* path, double frameId, double threshold, double red, double green, double blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginFillThresholdColorsRGBNameD(IntPtr path, double frameId, double threshold, double red, double green, double blue);
		/// <summary>
		/// Fill all frames with RGB color where the animation color is less than the 
		/// RGB threshold. Animation is referenced by id.
		/// EXPORT_API void PluginFillThresholdRGBColorsAllFramesRGB(int animationId, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillThresholdRGBColorsAllFramesRGB(int animationId, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue);
		/// <summary>
		/// Fill all frames with RGB color where the animation color is less than the 
		/// RGB threshold. Animation is referenced by name.
		/// EXPORT_API void PluginFillThresholdRGBColorsAllFramesRGBName(const char* path, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillThresholdRGBColorsAllFramesRGBName(IntPtr path, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginFillThresholdRGBColorsAllFramesRGBNameD(const char* path, double redThreshold, double greenThreshold, double blueThreshold, double red, double green, double blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginFillThresholdRGBColorsAllFramesRGBNameD(IntPtr path, double redThreshold, double greenThreshold, double blueThreshold, double red, double green, double blue);
		/// <summary>
		/// Fill the specified frame with RGB color where the animation color is less 
		/// than the RGB threshold. Animation is referenced by id.
		/// EXPORT_API void PluginFillThresholdRGBColorsRGB(int animationId, int frameId, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillThresholdRGBColorsRGB(int animationId, int frameId, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue);
		/// <summary>
		/// Fill the specified frame with RGB color where the animation color is less 
		/// than the RGB threshold. Animation is referenced by name.
		/// EXPORT_API void PluginFillThresholdRGBColorsRGBName(const char* path, int frameId, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillThresholdRGBColorsRGBName(IntPtr path, int frameId, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginFillThresholdRGBColorsRGBNameD(const char* path, double frameId, double redThreshold, double greenThreshold, double blueThreshold, double red, double green, double blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginFillThresholdRGBColorsRGBNameD(IntPtr path, double frameId, double redThreshold, double greenThreshold, double blueThreshold, double red, double green, double blue);
		/// <summary>
		/// Fill the specified frame with RGB color where the animation color is zero. 
		/// Animation is referenced by id.
		/// EXPORT_API void PluginFillZeroColor(int animationId, int frameId, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillZeroColor(int animationId, int frameId, int color);
		/// <summary>
		/// Fill all frames with RGB color where the animation color is zero. Animation 
		/// is referenced by id.
		/// EXPORT_API void PluginFillZeroColorAllFrames(int animationId, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillZeroColorAllFrames(int animationId, int color);
		/// <summary>
		/// Fill all frames with RGB color where the animation color is zero. Animation 
		/// is referenced by name.
		/// EXPORT_API void PluginFillZeroColorAllFramesName(const char* path, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillZeroColorAllFramesName(IntPtr path, int color);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginFillZeroColorAllFramesNameD(const char* path, double color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginFillZeroColorAllFramesNameD(IntPtr path, double color);
		/// <summary>
		/// Fill all frames with RGB color where the animation color is zero. Animation 
		/// is referenced by id.
		/// EXPORT_API void PluginFillZeroColorAllFramesRGB(int animationId, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillZeroColorAllFramesRGB(int animationId, int red, int green, int blue);
		/// <summary>
		/// Fill all frames with RGB color where the animation color is zero. Animation 
		/// is referenced by name.
		/// EXPORT_API void PluginFillZeroColorAllFramesRGBName(const char* path, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillZeroColorAllFramesRGBName(IntPtr path, int red, int green, int blue);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginFillZeroColorAllFramesRGBNameD(const char* path, double red, double green, double blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginFillZeroColorAllFramesRGBNameD(IntPtr path, double red, double green, double blue);
		/// <summary>
		/// Fill the specified frame with RGB color where the animation color is zero. 
		/// Animation is referenced by name.
		/// EXPORT_API void PluginFillZeroColorName(const char* path, int frameId, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillZeroColorName(IntPtr path, int frameId, int color);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginFillZeroColorNameD(const char* path, double frameId, double color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginFillZeroColorNameD(IntPtr path, double frameId, double color);
		/// <summary>
		/// Fill the specified frame with RGB color where the animation color is zero. 
		/// Animation is referenced by id.
		/// EXPORT_API void PluginFillZeroColorRGB(int animationId, int frameId, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillZeroColorRGB(int animationId, int frameId, int red, int green, int blue);
		/// <summary>
		/// Fill the specified frame with RGB color where the animation color is zero. 
		/// Animation is referenced by name.
		/// EXPORT_API void PluginFillZeroColorRGBName(const char* path, int frameId, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginFillZeroColorRGBName(IntPtr path, int frameId, int red, int green, int blue);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginFillZeroColorRGBNameD(const char* path, double frameId, double red, double green, double blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginFillZeroColorRGBNameD(IntPtr path, double frameId, double red, double green, double blue);
		/// <summary>
		/// Get the animation color for a frame given the `1D` `led`. The `led` should 
		/// be greater than or equal to 0 and less than the `MaxLeds`. Animation is 
		/// referenced by id.
		/// EXPORT_API int PluginGet1DColor(int animationId, int frameId, int led);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginGet1DColor(int animationId, int frameId, int led);
		/// <summary>
		/// Get the animation color for a frame given the `1D` `led`. The `led` should 
		/// be greater than or equal to 0 and less than the `MaxLeds`. Animation is 
		/// referenced by name.
		/// EXPORT_API int PluginGet1DColorName(const char* path, int frameId, int led);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginGet1DColorName(IntPtr path, int frameId, int led);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginGet1DColorNameD(const char* path, double frameId, double led);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginGet1DColorNameD(IntPtr path, double frameId, double led);
		/// <summary>
		/// Get the animation color for a frame given the `2D` `row` and `column`. The 
		/// `row` should be greater than or equal to 0 and less than the `MaxRow`. 
		/// The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		/// Animation is referenced by id.
		/// EXPORT_API int PluginGet2DColor(int animationId, int frameId, int row, int column);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginGet2DColor(int animationId, int frameId, int row, int column);
		/// <summary>
		/// Get the animation color for a frame given the `2D` `row` and `column`. The 
		/// `row` should be greater than or equal to 0 and less than the `MaxRow`. 
		/// The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		/// Animation is referenced by name.
		/// EXPORT_API int PluginGet2DColorName(const char* path, int frameId, int row, int column);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginGet2DColorName(IntPtr path, int frameId, int row, int column);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginGet2DColorNameD(const char* path, double frameId, double row, double column);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginGet2DColorNameD(IntPtr path, double frameId, double row, double column);
		/// <summary>
		/// Get the animation id for the named animation.
		/// EXPORT_API int PluginGetAnimation(const char* name);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginGetAnimation(IntPtr name);
		/// <summary>
		/// `PluginGetAnimationCount` will return the number of loaded animations.
		/// EXPORT_API int PluginGetAnimationCount();
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginGetAnimationCount();
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginGetAnimationD(const char* name);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginGetAnimationD(IntPtr name);
		/// <summary>
		/// `PluginGetAnimationId` will return the `animationId` given the `index` of 
		/// the loaded animation. The `index` is zero-based and less than the number 
		/// returned by `PluginGetAnimationCount`. Use `PluginGetAnimationName` to 
		/// get the name of the animation.
		/// EXPORT_API int PluginGetAnimationId(int index);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginGetAnimationId(int index);
		/// <summary>
		/// `PluginGetAnimationName` takes an `animationId` and returns the name of 
		/// the animation of the `.chroma` animation file. If a name is not available 
		/// then an empty string will be returned.
		/// EXPORT_API const char* PluginGetAnimationName(int animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr PluginGetAnimationName(int animationId);
		/// <summary>
		/// Get the current frame of the animation referenced by id.
		/// EXPORT_API int PluginGetCurrentFrame(int animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginGetCurrentFrame(int animationId);
		/// <summary>
		/// Get the current frame of the animation referenced by name.
		/// EXPORT_API int PluginGetCurrentFrameName(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginGetCurrentFrameName(IntPtr path);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginGetCurrentFrameNameD(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginGetCurrentFrameNameD(IntPtr path);
		/// <summary>
		/// Returns the `EChromaSDKDevice1DEnum` or `EChromaSDKDevice2DEnum` of a `Chroma` 
		/// animation respective to the `deviceType`, as an integer upon success. Returns 
		/// negative one upon failure.
		/// EXPORT_API int PluginGetDevice(int animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginGetDevice(int animationId);
		/// <summary>
		/// Returns the `EChromaSDKDevice1DEnum` or `EChromaSDKDevice2DEnum` of a `Chroma` 
		/// animation respective to the `deviceType`, as an integer upon success. Returns 
		/// negative one upon failure.
		/// EXPORT_API int PluginGetDeviceName(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginGetDeviceName(IntPtr path);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginGetDeviceNameD(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginGetDeviceNameD(IntPtr path);
		/// <summary>
		/// Returns the `EChromaSDKDeviceTypeEnum` of a `Chroma` animation as an integer 
		/// upon success. Returns negative one upon failure.
		/// EXPORT_API int PluginGetDeviceType(int animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginGetDeviceType(int animationId);
		/// <summary>
		/// Returns the `EChromaSDKDeviceTypeEnum` of a `Chroma` animation as an integer 
		/// upon success. Returns negative one upon failure.
		/// EXPORT_API int PluginGetDeviceTypeName(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginGetDeviceTypeName(IntPtr path);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginGetDeviceTypeNameD(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginGetDeviceTypeNameD(IntPtr path);
		/// <summary>
		/// Gets the frame colors and duration (in seconds) for a `Chroma` animation. 
		/// The `color` is expected to be an array of the expected dimensions for the 
		/// `deviceType/device`. The `length` parameter is the size of the `color` 
		/// array. For `EChromaSDKDevice1DEnum` the array size should be `MAX LEDS`. 
		/// For `EChromaSDKDevice2DEnum` the array size should be `MAX ROW` * `MAX 
		/// COLUMN`. Returns the animation id upon success. Returns negative one upon 
		/// failure.
		/// EXPORT_API int PluginGetFrame(int animationId, int frameIndex, float* duration, int* colors, int length);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginGetFrame(int animationId, int frameIndex, out float duration, int[] colors, int length);
		/// <summary>
		/// Returns the frame count of a `Chroma` animation upon success. Returns negative 
		/// one upon failure.
		/// EXPORT_API int PluginGetFrameCount(int animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginGetFrameCount(int animationId);
		/// <summary>
		/// Returns the frame count of a `Chroma` animation upon success. Returns negative 
		/// one upon failure.
		/// EXPORT_API int PluginGetFrameCountName(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginGetFrameCountName(IntPtr path);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginGetFrameCountNameD(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginGetFrameCountNameD(IntPtr path);
		/// <summary>
		/// Get the color of an animation key for the given frame referenced by id. 
		///
		/// EXPORT_API int PluginGetKeyColor(int animationId, int frameId, int rzkey);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginGetKeyColor(int animationId, int frameId, int rzkey);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginGetKeyColorD(const char* path, double frameId, double rzkey);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginGetKeyColorD(IntPtr path, double frameId, double rzkey);
		/// <summary>
		/// Get the color of an animation key for the given frame referenced by name. 
		///
		/// EXPORT_API int PluginGetKeyColorName(const char* path, int frameId, int rzkey);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginGetKeyColorName(IntPtr path, int frameId, int rzkey);
		/// <summary>
		/// Returns `RZRESULT_SUCCESS` if the plugin has been initialized successfully. 
		/// Returns `RZRESULT_DLL_NOT_FOUND` if core Chroma library is not found. Returns 
		/// `RZRESULT_DLL_INVALID_SIGNATURE` if core Chroma library has an invalid 
		/// signature.
		/// EXPORT_API RZRESULT PluginGetLibraryLoadedState();
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginGetLibraryLoadedState();
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginGetLibraryLoadedStateD();
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginGetLibraryLoadedStateD();
		/// <summary>
		/// Returns the `MAX COLUMN` given the `EChromaSDKDevice2DEnum` device as an 
		/// integer upon success. Returns negative one upon failure.
		/// EXPORT_API int PluginGetMaxColumn(int device);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginGetMaxColumn(int device);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginGetMaxColumnD(double device);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginGetMaxColumnD(double device);
		/// <summary>
		/// Returns the MAX LEDS given the `EChromaSDKDevice1DEnum` device as an integer 
		/// upon success. Returns negative one upon failure.
		/// EXPORT_API int PluginGetMaxLeds(int device);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginGetMaxLeds(int device);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginGetMaxLedsD(double device);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginGetMaxLedsD(double device);
		/// <summary>
		/// Returns the `MAX ROW` given the `EChromaSDKDevice2DEnum` device as an integer 
		/// upon success. Returns negative one upon failure.
		/// EXPORT_API int PluginGetMaxRow(int device);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginGetMaxRow(int device);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginGetMaxRowD(double device);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginGetMaxRowD(double device);
		/// <summary>
		/// `PluginGetPlayingAnimationCount` will return the number of playing animations. 
		///
		/// EXPORT_API int PluginGetPlayingAnimationCount();
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginGetPlayingAnimationCount();
		/// <summary>
		/// `PluginGetPlayingAnimationId` will return the `animationId` given the `index` 
		/// of the playing animation. The `index` is zero-based and less than the number 
		/// returned by `PluginGetPlayingAnimationCount`. Use `PluginGetAnimationName` 
		/// to get the name of the animation.
		/// EXPORT_API int PluginGetPlayingAnimationId(int index);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginGetPlayingAnimationId(int index);
		/// <summary>
		/// Get the RGB color given red, green, and blue.
		/// EXPORT_API int PluginGetRGB(int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginGetRGB(int red, int green, int blue);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginGetRGBD(double red, double green, double blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginGetRGBD(double red, double green, double blue);
		/// <summary>
		/// Check if the animation has loop enabled referenced by id.
		/// EXPORT_API bool PluginHasAnimationLoop(int animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern bool PluginHasAnimationLoop(int animationId);
		/// <summary>
		/// Check if the animation has loop enabled referenced by name.
		/// EXPORT_API bool PluginHasAnimationLoopName(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern bool PluginHasAnimationLoopName(IntPtr path);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginHasAnimationLoopNameD(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginHasAnimationLoopNameD(IntPtr path);
		/// <summary>
		/// Initialize the ChromaSDK. Zero indicates  success, otherwise failure. Many 
		/// API methods auto initialize the ChromaSDK if not already initialized.
		/// EXPORT_API RZRESULT PluginInit();
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginInit();
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginInitD();
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginInitD();
		/// <summary>
		/// Initialize the ChromaSDK. AppInfo populates the details in Synapse. Zero 
		/// indicates  success, otherwise failure. Many API methods auto initialize 
		/// the ChromaSDK if not already initialized.
		/// EXPORT_API RZRESULT PluginInitSDK(ChromaSDK::APPINFOTYPE* AppInfo);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginInitSDK(ref ChromaSDK.APPINFOTYPE appInfo);
		/// <summary>
		/// Insert an animation delay by duplicating the frame by the delay number of 
		/// times. Animation is referenced by id.
		/// EXPORT_API void PluginInsertDelay(int animationId, int frameId, int delay);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginInsertDelay(int animationId, int frameId, int delay);
		/// <summary>
		/// Insert an animation delay by duplicating the frame by the delay number of 
		/// times. Animation is referenced by name.
		/// EXPORT_API void PluginInsertDelayName(const char* path, int frameId, int delay);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginInsertDelayName(IntPtr path, int frameId, int delay);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginInsertDelayNameD(const char* path, double frameId, double delay);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginInsertDelayNameD(IntPtr path, double frameId, double delay);
		/// <summary>
		/// Duplicate the source frame index at the target frame index. Animation is 
		/// referenced by id.
		/// EXPORT_API void PluginInsertFrame(int animationId, int sourceFrame, int targetFrame);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginInsertFrame(int animationId, int sourceFrame, int targetFrame);
		/// <summary>
		/// Duplicate the source frame index at the target frame index. Animation is 
		/// referenced by name.
		/// EXPORT_API void PluginInsertFrameName(const char* path, int sourceFrame, int targetFrame);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginInsertFrameName(IntPtr path, int sourceFrame, int targetFrame);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginInsertFrameNameD(const char* path, double sourceFrame, double targetFrame);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginInsertFrameNameD(IntPtr path, double sourceFrame, double targetFrame);
		/// <summary>
		/// Invert all the colors at the specified frame. Animation is referenced by 
		/// id.
		/// EXPORT_API void PluginInvertColors(int animationId, int frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginInvertColors(int animationId, int frameId);
		/// <summary>
		/// Invert all the colors for all frames. Animation is referenced by id.
		/// EXPORT_API void PluginInvertColorsAllFrames(int animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginInvertColorsAllFrames(int animationId);
		/// <summary>
		/// Invert all the colors for all frames. Animation is referenced by name.
		/// EXPORT_API void PluginInvertColorsAllFramesName(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginInvertColorsAllFramesName(IntPtr path);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginInvertColorsAllFramesNameD(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginInvertColorsAllFramesNameD(IntPtr path);
		/// <summary>
		/// Invert all the colors at the specified frame. Animation is referenced by 
		/// name.
		/// EXPORT_API void PluginInvertColorsName(const char* path, int frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginInvertColorsName(IntPtr path, int frameId);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginInvertColorsNameD(const char* path, double frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginInvertColorsNameD(IntPtr path, double frameId);
		/// <summary>
		/// Check if the animation is paused referenced by id.
		/// EXPORT_API bool PluginIsAnimationPaused(int animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern bool PluginIsAnimationPaused(int animationId);
		/// <summary>
		/// Check if the animation is paused referenced by name.
		/// EXPORT_API bool PluginIsAnimationPausedName(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern bool PluginIsAnimationPausedName(IntPtr path);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginIsAnimationPausedNameD(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginIsAnimationPausedNameD(IntPtr path);
		/// <summary>
		/// The editor dialog is a non-blocking modal window, this method returns true 
		/// if the modal window is open, otherwise false.
		/// EXPORT_API bool PluginIsDialogOpen();
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern bool PluginIsDialogOpen();
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginIsDialogOpenD();
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginIsDialogOpenD();
		/// <summary>
		/// Returns true if the plugin has been initialized. Returns false if the plugin 
		/// is uninitialized.
		/// EXPORT_API bool PluginIsInitialized();
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern bool PluginIsInitialized();
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginIsInitializedD();
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginIsInitializedD();
		/// <summary>
		/// If the method can be invoked the method returns true.
		/// EXPORT_API bool PluginIsPlatformSupported();
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern bool PluginIsPlatformSupported();
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginIsPlatformSupportedD();
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginIsPlatformSupportedD();
		/// <summary>
		/// `PluginIsPlayingName` automatically handles initializing the `ChromaSDK`. 
		/// The named `.chroma` animation file will be automatically opened. The method 
		/// will return whether the animation is playing or not. Animation is referenced 
		/// by id.
		/// EXPORT_API bool PluginIsPlaying(int animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern bool PluginIsPlaying(int animationId);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginIsPlayingD(double animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginIsPlayingD(double animationId);
		/// <summary>
		/// `PluginIsPlayingName` automatically handles initializing the `ChromaSDK`. 
		/// The named `.chroma` animation file will be automatically opened. The method 
		/// will return whether the animation is playing or not. Animation is referenced 
		/// by name.
		/// EXPORT_API bool PluginIsPlayingName(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern bool PluginIsPlayingName(IntPtr path);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginIsPlayingNameD(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginIsPlayingNameD(IntPtr path);
		/// <summary>
		/// `PluginIsPlayingType` automatically handles initializing the `ChromaSDK`. 
		/// If any animation is playing for the `deviceType` and `device` combination, 
		/// the method will return true, otherwise false.
		/// EXPORT_API bool PluginIsPlayingType(int deviceType, int device);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern bool PluginIsPlayingType(int deviceType, int device);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginIsPlayingTypeD(double deviceType, double device);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginIsPlayingTypeD(double deviceType, double device);
		/// <summary>
		/// Do a lerp math operation on a float.
		/// EXPORT_API float PluginLerp(float start, float end, float amt);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern float PluginLerp(float start, float end, float amt);
		/// <summary>
		/// Lerp from one color to another given t in the range 0.0 to 1.0.
		/// EXPORT_API int PluginLerpColor(int from, int to, float t);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginLerpColor(int from, int to, float t);
		/// <summary>
		/// Loads `Chroma` effects so that the animation can be played immediately. 
		/// Returns the animation id upon success. Returns negative one upon failure. 
		///
		/// EXPORT_API int PluginLoadAnimation(int animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginLoadAnimation(int animationId);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginLoadAnimationD(double animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginLoadAnimationD(double animationId);
		/// <summary>
		/// Load the named animation.
		/// EXPORT_API void PluginLoadAnimationName(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginLoadAnimationName(IntPtr path);
		/// <summary>
		/// Load a composite set of animations.
		/// EXPORT_API void PluginLoadComposite(const char* name);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginLoadComposite(IntPtr name);
		/// <summary>
		/// Make a blank animation for the length of the frame count. Frame duration 
		/// defaults to the duration. The frame color defaults to color. Animation 
		/// is referenced by id.
		/// EXPORT_API void PluginMakeBlankFrames(int animationId, int frameCount, float duration, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMakeBlankFrames(int animationId, int frameCount, float duration, int color);
		/// <summary>
		/// Make a blank animation for the length of the frame count. Frame duration 
		/// defaults to the duration. The frame color defaults to color. Animation 
		/// is referenced by name.
		/// EXPORT_API void PluginMakeBlankFramesName(const char* path, int frameCount, float duration, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMakeBlankFramesName(IntPtr path, int frameCount, float duration, int color);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginMakeBlankFramesNameD(const char* path, double frameCount, double duration, double color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginMakeBlankFramesNameD(IntPtr path, double frameCount, double duration, double color);
		/// <summary>
		/// Make a blank animation for the length of the frame count. Frame duration 
		/// defaults to the duration. The frame color is random. Animation is referenced 
		/// by id.
		/// EXPORT_API void PluginMakeBlankFramesRandom(int animationId, int frameCount, float duration);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMakeBlankFramesRandom(int animationId, int frameCount, float duration);
		/// <summary>
		/// Make a blank animation for the length of the frame count. Frame duration 
		/// defaults to the duration. The frame color is random black and white. Animation 
		/// is referenced by id.
		/// EXPORT_API void PluginMakeBlankFramesRandomBlackAndWhite(int animationId, int frameCount, float duration);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMakeBlankFramesRandomBlackAndWhite(int animationId, int frameCount, float duration);
		/// <summary>
		/// Make a blank animation for the length of the frame count. Frame duration 
		/// defaults to the duration. The frame color is random black and white. Animation 
		/// is referenced by name.
		/// EXPORT_API void PluginMakeBlankFramesRandomBlackAndWhiteName(const char* path, int frameCount, float duration);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMakeBlankFramesRandomBlackAndWhiteName(IntPtr path, int frameCount, float duration);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginMakeBlankFramesRandomBlackAndWhiteNameD(const char* path, double frameCount, double duration);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginMakeBlankFramesRandomBlackAndWhiteNameD(IntPtr path, double frameCount, double duration);
		/// <summary>
		/// Make a blank animation for the length of the frame count. Frame duration 
		/// defaults to the duration. The frame color is random. Animation is referenced 
		/// by name.
		/// EXPORT_API void PluginMakeBlankFramesRandomName(const char* path, int frameCount, float duration);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMakeBlankFramesRandomName(IntPtr path, int frameCount, float duration);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginMakeBlankFramesRandomNameD(const char* path, double frameCount, double duration);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginMakeBlankFramesRandomNameD(IntPtr path, double frameCount, double duration);
		/// <summary>
		/// Make a blank animation for the length of the frame count. Frame duration 
		/// defaults to the duration. The frame color defaults to color. Animation 
		/// is referenced by id.
		/// EXPORT_API void PluginMakeBlankFramesRGB(int animationId, int frameCount, float duration, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMakeBlankFramesRGB(int animationId, int frameCount, float duration, int red, int green, int blue);
		/// <summary>
		/// Make a blank animation for the length of the frame count. Frame duration 
		/// defaults to the duration. The frame color defaults to color. Animation 
		/// is referenced by name.
		/// EXPORT_API void PluginMakeBlankFramesRGBName(const char* path, int frameCount, float duration, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMakeBlankFramesRGBName(IntPtr path, int frameCount, float duration, int red, int green, int blue);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginMakeBlankFramesRGBNameD(const char* path, double frameCount, double duration, double red, double green, double blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginMakeBlankFramesRGBNameD(IntPtr path, double frameCount, double duration, double red, double green, double blue);
		/// <summary>
		/// Flips the color grid horizontally for all `Chroma` animation frames. Returns 
		/// the animation id upon success. Returns negative one upon failure.
		/// EXPORT_API int PluginMirrorHorizontally(int animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginMirrorHorizontally(int animationId);
		/// <summary>
		/// Flips the color grid vertically for all `Chroma` animation frames. This 
		/// method has no effect for `EChromaSDKDevice1DEnum` devices. Returns the 
		/// animation id upon success. Returns negative one upon failure.
		/// EXPORT_API int PluginMirrorVertically(int animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginMirrorVertically(int animationId);
		/// <summary>
		/// Multiply the color intensity with the lerp result from color 1 to color 
		/// 2 using the frame index divided by the frame count for the `t` parameter. 
		/// Animation is referenced in id.
		/// EXPORT_API void PluginMultiplyColorLerpAllFrames(int animationId, int color1, int color2);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMultiplyColorLerpAllFrames(int animationId, int color1, int color2);
		/// <summary>
		/// Multiply the color intensity with the lerp result from color 1 to color 
		/// 2 using the frame index divided by the frame count for the `t` parameter. 
		/// Animation is referenced in name.
		/// EXPORT_API void PluginMultiplyColorLerpAllFramesName(const char* path, int color1, int color2);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMultiplyColorLerpAllFramesName(IntPtr path, int color1, int color2);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginMultiplyColorLerpAllFramesNameD(const char* path, double color1, double color2);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginMultiplyColorLerpAllFramesNameD(IntPtr path, double color1, double color2);
		/// <summary>
		/// Multiply all the colors in the frame by the intensity value. The valid the 
		/// intensity range is from 0.0 to 255.0. RGB components are multiplied equally. 
		/// An intensity of 0.5 would half the color value. Black colors in the frame 
		/// will not be affected by this method.
		/// EXPORT_API void PluginMultiplyIntensity(int animationId, int frameId, float intensity);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMultiplyIntensity(int animationId, int frameId, float intensity);
		/// <summary>
		/// Multiply all the colors for all frames by the intensity value. The valid 
		/// the intensity range is from 0.0 to 255.0. RGB components are multiplied 
		/// equally. An intensity of 0.5 would half the color value. Black colors in 
		/// the frame will not be affected by this method.
		/// EXPORT_API void PluginMultiplyIntensityAllFrames(int animationId, float intensity);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMultiplyIntensityAllFrames(int animationId, float intensity);
		/// <summary>
		/// Multiply all the colors for all frames by the intensity value. The valid 
		/// the intensity range is from 0.0 to 255.0. RGB components are multiplied 
		/// equally. An intensity of 0.5 would half the color value. Black colors in 
		/// the frame will not be affected by this method.
		/// EXPORT_API void PluginMultiplyIntensityAllFramesName(const char* path, float intensity);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMultiplyIntensityAllFramesName(IntPtr path, float intensity);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginMultiplyIntensityAllFramesNameD(const char* path, double intensity);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginMultiplyIntensityAllFramesNameD(IntPtr path, double intensity);
		/// <summary>
		/// Multiply all frames by the RBG color intensity. Animation is referenced 
		/// by id.
		/// EXPORT_API void PluginMultiplyIntensityAllFramesRGB(int animationId, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMultiplyIntensityAllFramesRGB(int animationId, int red, int green, int blue);
		/// <summary>
		/// Multiply all frames by the RBG color intensity. Animation is referenced 
		/// by name.
		/// EXPORT_API void PluginMultiplyIntensityAllFramesRGBName(const char* path, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMultiplyIntensityAllFramesRGBName(IntPtr path, int red, int green, int blue);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginMultiplyIntensityAllFramesRGBNameD(const char* path, double red, double green, double blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginMultiplyIntensityAllFramesRGBNameD(IntPtr path, double red, double green, double blue);
		/// <summary>
		/// Multiply the specific frame by the RBG color intensity. Animation is referenced 
		/// by id.
		/// EXPORT_API void PluginMultiplyIntensityColor(int animationId, int frameId, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMultiplyIntensityColor(int animationId, int frameId, int color);
		/// <summary>
		/// Multiply all frames by the RBG color intensity. Animation is referenced 
		/// by id.
		/// EXPORT_API void PluginMultiplyIntensityColorAllFrames(int animationId, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMultiplyIntensityColorAllFrames(int animationId, int color);
		/// <summary>
		/// Multiply all frames by the RBG color intensity. Animation is referenced 
		/// by name.
		/// EXPORT_API void PluginMultiplyIntensityColorAllFramesName(const char* path, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMultiplyIntensityColorAllFramesName(IntPtr path, int color);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginMultiplyIntensityColorAllFramesNameD(const char* path, double color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginMultiplyIntensityColorAllFramesNameD(IntPtr path, double color);
		/// <summary>
		/// Multiply the specific frame by the RBG color intensity. Animation is referenced 
		/// by name.
		/// EXPORT_API void PluginMultiplyIntensityColorName(const char* path, int frameId, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMultiplyIntensityColorName(IntPtr path, int frameId, int color);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginMultiplyIntensityColorNameD(const char* path, double frameId, double color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginMultiplyIntensityColorNameD(IntPtr path, double frameId, double color);
		/// <summary>
		/// Multiply all the colors in the frame by the intensity value. The valid the 
		/// intensity range is from 0.0 to 255.0. RGB components are multiplied equally. 
		/// An intensity of 0.5 would half the color value. Black colors in the frame 
		/// will not be affected by this method.
		/// EXPORT_API void PluginMultiplyIntensityName(const char* path, int frameId, float intensity);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMultiplyIntensityName(IntPtr path, int frameId, float intensity);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginMultiplyIntensityNameD(const char* path, double frameId, double intensity);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginMultiplyIntensityNameD(IntPtr path, double frameId, double intensity);
		/// <summary>
		/// Multiply the specific frame by the RBG color intensity. Animation is referenced 
		/// by id.
		/// EXPORT_API void PluginMultiplyIntensityRGB(int animationId, int frameId, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMultiplyIntensityRGB(int animationId, int frameId, int red, int green, int blue);
		/// <summary>
		/// Multiply the specific frame by the RBG color intensity. Animation is referenced 
		/// by name.
		/// EXPORT_API void PluginMultiplyIntensityRGBName(const char* path, int frameId, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMultiplyIntensityRGBName(IntPtr path, int frameId, int red, int green, int blue);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginMultiplyIntensityRGBNameD(const char* path, double frameId, double red, double green, double blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginMultiplyIntensityRGBNameD(IntPtr path, double frameId, double red, double green, double blue);
		/// <summary>
		/// Multiply the specific frame by the color lerp result between color 1 and 
		/// 2 using the frame color value as the `t` value. Animation is referenced 
		/// by id.
		/// EXPORT_API void PluginMultiplyNonZeroTargetColorLerp(int animationId, int frameId, int color1, int color2);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMultiplyNonZeroTargetColorLerp(int animationId, int frameId, int color1, int color2);
		/// <summary>
		/// Multiply all frames by the color lerp result between color 1 and 2 using 
		/// the frame color value as the `t` value. Animation is referenced by id. 
		///
		/// EXPORT_API void PluginMultiplyNonZeroTargetColorLerpAllFrames(int animationId, int color1, int color2);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMultiplyNonZeroTargetColorLerpAllFrames(int animationId, int color1, int color2);
		/// <summary>
		/// Multiply all frames by the color lerp result between color 1 and 2 using 
		/// the frame color value as the `t` value. Animation is referenced by name. 
		///
		/// EXPORT_API void PluginMultiplyNonZeroTargetColorLerpAllFramesName(const char* path, int color1, int color2);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMultiplyNonZeroTargetColorLerpAllFramesName(IntPtr path, int color1, int color2);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginMultiplyNonZeroTargetColorLerpAllFramesNameD(const char* path, double color1, double color2);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginMultiplyNonZeroTargetColorLerpAllFramesNameD(IntPtr path, double color1, double color2);
		/// <summary>
		/// Multiply the specific frame by the color lerp result between RGB 1 and 2 
		/// using the frame color value as the `t` value. Animation is referenced by 
		/// id.
		/// EXPORT_API void PluginMultiplyNonZeroTargetColorLerpAllFramesRGB(int animationId, int red1, int green1, int blue1, int red2, int green2, int blue2);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMultiplyNonZeroTargetColorLerpAllFramesRGB(int animationId, int red1, int green1, int blue1, int red2, int green2, int blue2);
		/// <summary>
		/// Multiply the specific frame by the color lerp result between RGB 1 and 2 
		/// using the frame color value as the `t` value. Animation is referenced by 
		/// name.
		/// EXPORT_API void PluginMultiplyNonZeroTargetColorLerpAllFramesRGBName(const char* path, int red1, int green1, int blue1, int red2, int green2, int blue2);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMultiplyNonZeroTargetColorLerpAllFramesRGBName(IntPtr path, int red1, int green1, int blue1, int red2, int green2, int blue2);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginMultiplyNonZeroTargetColorLerpAllFramesRGBNameD(const char* path, double red1, double green1, double blue1, double red2, double green2, double blue2);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginMultiplyNonZeroTargetColorLerpAllFramesRGBNameD(IntPtr path, double red1, double green1, double blue1, double red2, double green2, double blue2);
		/// <summary>
		/// Multiply the specific frame by the color lerp result between color 1 and 
		/// 2 using the frame color value as the `t` value. Animation is referenced 
		/// by id.
		/// EXPORT_API void PluginMultiplyTargetColorLerp(int animationId, int frameId, int color1, int color2);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMultiplyTargetColorLerp(int animationId, int frameId, int color1, int color2);
		/// <summary>
		/// Multiply all frames by the color lerp result between color 1 and 2 using 
		/// the frame color value as the `t` value. Animation is referenced by id. 
		///
		/// EXPORT_API void PluginMultiplyTargetColorLerpAllFrames(int animationId, int color1, int color2);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMultiplyTargetColorLerpAllFrames(int animationId, int color1, int color2);
		/// <summary>
		/// Multiply all frames by the color lerp result between color 1 and 2 using 
		/// the frame color value as the `t` value. Animation is referenced by name. 
		///
		/// EXPORT_API void PluginMultiplyTargetColorLerpAllFramesName(const char* path, int color1, int color2);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMultiplyTargetColorLerpAllFramesName(IntPtr path, int color1, int color2);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginMultiplyTargetColorLerpAllFramesNameD(const char* path, double color1, double color2);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginMultiplyTargetColorLerpAllFramesNameD(IntPtr path, double color1, double color2);
		/// <summary>
		/// Multiply all frames by the color lerp result between RGB 1 and 2 using the 
		/// frame color value as the `t` value. Animation is referenced by id.
		/// EXPORT_API void PluginMultiplyTargetColorLerpAllFramesRGB(int animationId, int red1, int green1, int blue1, int red2, int green2, int blue2);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMultiplyTargetColorLerpAllFramesRGB(int animationId, int red1, int green1, int blue1, int red2, int green2, int blue2);
		/// <summary>
		/// Multiply all frames by the color lerp result between RGB 1 and 2 using the 
		/// frame color value as the `t` value. Animation is referenced by name.
		/// EXPORT_API void PluginMultiplyTargetColorLerpAllFramesRGBName(const char* path, int red1, int green1, int blue1, int red2, int green2, int blue2);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMultiplyTargetColorLerpAllFramesRGBName(IntPtr path, int red1, int green1, int blue1, int red2, int green2, int blue2);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginMultiplyTargetColorLerpAllFramesRGBNameD(const char* path, double red1, double green1, double blue1, double red2, double green2, double blue2);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginMultiplyTargetColorLerpAllFramesRGBNameD(IntPtr path, double red1, double green1, double blue1, double red2, double green2, double blue2);
		/// <summary>
		/// Multiply the specific frame by the color lerp result between color 1 and 
		/// 2 using the frame color value as the `t` value. Animation is referenced 
		/// by name.
		/// EXPORT_API void PluginMultiplyTargetColorLerpName(const char* path, int frameId, int color1, int color2);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginMultiplyTargetColorLerpName(IntPtr path, int frameId, int color1, int color2);
		/// <summary>
		/// Offset all colors in the frame using the RGB offset. Use the range of -255 
		/// to 255 for red, green, and blue parameters. Negative values remove color. 
		/// Positive values add color.
		/// EXPORT_API void PluginOffsetColors(int animationId, int frameId, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginOffsetColors(int animationId, int frameId, int red, int green, int blue);
		/// <summary>
		/// Offset all colors for all frames using the RGB offset. Use the range of 
		/// -255 to 255 for red, green, and blue parameters. Negative values remove 
		/// color. Positive values add color.
		/// EXPORT_API void PluginOffsetColorsAllFrames(int animationId, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginOffsetColorsAllFrames(int animationId, int red, int green, int blue);
		/// <summary>
		/// Offset all colors for all frames using the RGB offset. Use the range of 
		/// -255 to 255 for red, green, and blue parameters. Negative values remove 
		/// color. Positive values add color.
		/// EXPORT_API void PluginOffsetColorsAllFramesName(const char* path, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginOffsetColorsAllFramesName(IntPtr path, int red, int green, int blue);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginOffsetColorsAllFramesNameD(const char* path, double red, double green, double blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginOffsetColorsAllFramesNameD(IntPtr path, double red, double green, double blue);
		/// <summary>
		/// Offset all colors in the frame using the RGB offset. Use the range of -255 
		/// to 255 for red, green, and blue parameters. Negative values remove color. 
		/// Positive values add color.
		/// EXPORT_API void PluginOffsetColorsName(const char* path, int frameId, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginOffsetColorsName(IntPtr path, int frameId, int red, int green, int blue);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginOffsetColorsNameD(const char* path, double frameId, double red, double green, double blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginOffsetColorsNameD(IntPtr path, double frameId, double red, double green, double blue);
		/// <summary>
		/// This method will only update colors in the animation that are not already 
		/// set to black. Offset a subset of colors in the frame using the RGB offset. 
		/// Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		/// values remove color. Positive values add color.
		/// EXPORT_API void PluginOffsetNonZeroColors(int animationId, int frameId, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginOffsetNonZeroColors(int animationId, int frameId, int red, int green, int blue);
		/// <summary>
		/// This method will only update colors in the animation that are not already 
		/// set to black. Offset a subset of colors for all frames using the RGB offset. 
		/// Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		/// values remove color. Positive values add color.
		/// EXPORT_API void PluginOffsetNonZeroColorsAllFrames(int animationId, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginOffsetNonZeroColorsAllFrames(int animationId, int red, int green, int blue);
		/// <summary>
		/// This method will only update colors in the animation that are not already 
		/// set to black. Offset a subset of colors for all frames using the RGB offset. 
		/// Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		/// values remove color. Positive values add color.
		/// EXPORT_API void PluginOffsetNonZeroColorsAllFramesName(const char* path, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginOffsetNonZeroColorsAllFramesName(IntPtr path, int red, int green, int blue);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginOffsetNonZeroColorsAllFramesNameD(const char* path, double red, double green, double blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginOffsetNonZeroColorsAllFramesNameD(IntPtr path, double red, double green, double blue);
		/// <summary>
		/// This method will only update colors in the animation that are not already 
		/// set to black. Offset a subset of colors in the frame using the RGB offset. 
		/// Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		/// values remove color. Positive values add color.
		/// EXPORT_API void PluginOffsetNonZeroColorsName(const char* path, int frameId, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginOffsetNonZeroColorsName(IntPtr path, int frameId, int red, int green, int blue);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginOffsetNonZeroColorsNameD(const char* path, double frameId, double red, double green, double blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginOffsetNonZeroColorsNameD(IntPtr path, double frameId, double red, double green, double blue);
		/// <summary>
		/// Opens a `Chroma` animation file so that it can be played. Returns an animation 
		/// id >= 0 upon success. Returns negative one if there was a failure. The 
		/// animation id is used in most of the API methods.
		/// EXPORT_API int PluginOpenAnimation(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginOpenAnimation(IntPtr path);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginOpenAnimationD(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginOpenAnimationD(IntPtr path);
		/// <summary>
		/// Opens a `Chroma` animation data from memory so that it can be played. `Data` 
		/// is a pointer to BYTE array of the loaded animation in memory. `Name` will 
		/// be assigned to the animation when loaded. Returns an animation id >= 0 
		/// upon success. Returns negative one if there was a failure. The animation 
		/// id is used in most of the API methods.
		/// EXPORT_API int PluginOpenAnimationFromMemory(const BYTE* data, const char* name);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginOpenAnimationFromMemory(byte[] data, IntPtr name);
		/// <summary>
		/// Opens a `Chroma` animation file with the `.chroma` extension. Returns zero 
		/// upon success. Returns negative one if there was a failure.
		/// EXPORT_API int PluginOpenEditorDialog(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginOpenEditorDialog(IntPtr path);
		/// <summary>
		/// Open the named animation in the editor dialog and play the animation at 
		/// start.
		/// EXPORT_API int PluginOpenEditorDialogAndPlay(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginOpenEditorDialogAndPlay(IntPtr path);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginOpenEditorDialogAndPlayD(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginOpenEditorDialogAndPlayD(IntPtr path);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginOpenEditorDialogD(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginOpenEditorDialogD(IntPtr path);
		/// <summary>
		/// Sets the `duration` for all grames in the `Chroma` animation to the `duration` 
		/// parameter. Returns the animation id upon success. Returns negative one 
		/// upon failure.
		/// EXPORT_API int PluginOverrideFrameDuration(int animationId, float duration);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginOverrideFrameDuration(int animationId, float duration);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginOverrideFrameDurationD(double animationId, double duration);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginOverrideFrameDurationD(double animationId, double duration);
		/// <summary>
		/// Override the duration of all frames with the `duration` value. Animation 
		/// is referenced by name.
		/// EXPORT_API void PluginOverrideFrameDurationName(const char* path, float duration);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginOverrideFrameDurationName(IntPtr path, float duration);
		/// <summary>
		/// Pause the current animation referenced by id.
		/// EXPORT_API void PluginPauseAnimation(int animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginPauseAnimation(int animationId);
		/// <summary>
		/// Pause the current animation referenced by name.
		/// EXPORT_API void PluginPauseAnimationName(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginPauseAnimationName(IntPtr path);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginPauseAnimationNameD(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginPauseAnimationNameD(IntPtr path);
		/// <summary>
		/// Plays the `Chroma` animation. This will load the animation, if not loaded 
		/// previously. Returns the animation id upon success. Returns negative one 
		/// upon failure.
		/// EXPORT_API int PluginPlayAnimation(int animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginPlayAnimation(int animationId);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginPlayAnimationD(double animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginPlayAnimationD(double animationId);
		/// <summary>
		/// `PluginPlayAnimationFrame` automatically handles initializing the `ChromaSDK`. 
		/// The method will play the animation given the `animationId` with looping 
		/// `on` or `off` starting at the `frameId`.
		/// EXPORT_API void PluginPlayAnimationFrame(int animationId, int frameId, bool loop);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginPlayAnimationFrame(int animationId, int frameId, bool loop);
		/// <summary>
		/// `PluginPlayAnimationFrameName` automatically handles initializing the `ChromaSDK`. 
		/// The named `.chroma` animation file will be automatically opened. The animation 
		/// will play with looping `on` or `off` starting at the `frameId`.
		/// EXPORT_API void PluginPlayAnimationFrameName(const char* path, int frameId, bool loop);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginPlayAnimationFrameName(IntPtr path, int frameId, bool loop);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginPlayAnimationFrameNameD(const char* path, double frameId, double loop);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginPlayAnimationFrameNameD(IntPtr path, double frameId, double loop);
		/// <summary>
		/// `PluginPlayAnimationLoop` automatically handles initializing the `ChromaSDK`. 
		/// The method will play the animation given the `animationId` with looping 
		/// `on` or `off`.
		/// EXPORT_API void PluginPlayAnimationLoop(int animationId, bool loop);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginPlayAnimationLoop(int animationId, bool loop);
		/// <summary>
		/// `PluginPlayAnimationName` automatically handles initializing the `ChromaSDK`. 
		/// The named `.chroma` animation file will be automatically opened. The animation 
		/// will play with looping `on` or `off`.
		/// EXPORT_API void PluginPlayAnimationName(const char* path, bool loop);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginPlayAnimationName(IntPtr path, bool loop);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginPlayAnimationNameD(const char* path, double loop);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginPlayAnimationNameD(IntPtr path, double loop);
		/// <summary>
		/// `PluginPlayComposite` automatically handles initializing the `ChromaSDK`. 
		/// The named animation files for the `.chroma` set will be automatically opened. 
		/// The set of animations will play with looping `on` or `off`.
		/// EXPORT_API void PluginPlayComposite(const char* name, bool loop);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginPlayComposite(IntPtr name, bool loop);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginPlayCompositeD(const char* name, double loop);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginPlayCompositeD(IntPtr name, double loop);
		/// <summary>
		/// Displays the `Chroma` animation frame on `Chroma` hardware given the `frameIndex`. 
		/// Returns the animation id upon success. Returns negative one upon failure. 
		///
		/// EXPORT_API int PluginPreviewFrame(int animationId, int frameIndex);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginPreviewFrame(int animationId, int frameIndex);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginPreviewFrameD(double animationId, double frameIndex);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginPreviewFrameD(double animationId, double frameIndex);
		/// <summary>
		/// Displays the `Chroma` animation frame on `Chroma` hardware given the `frameIndex`. 
		/// Animaton is referenced by name.
		/// EXPORT_API void PluginPreviewFrameName(const char* path, int frameIndex);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginPreviewFrameName(IntPtr path, int frameIndex);
		/// <summary>
		/// Reduce the frames of the animation by removing every nth element. Animation 
		/// is referenced by id.
		/// EXPORT_API void PluginReduceFrames(int animationId, int n);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginReduceFrames(int animationId, int n);
		/// <summary>
		/// Reduce the frames of the animation by removing every nth element. Animation 
		/// is referenced by name.
		/// EXPORT_API void PluginReduceFramesName(const char* path, int n);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginReduceFramesName(IntPtr path, int n);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginReduceFramesNameD(const char* path, double n);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginReduceFramesNameD(IntPtr path, double n);
		/// <summary>
		/// Resets the `Chroma` animation to 1 blank frame. Returns the animation id 
		/// upon success. Returns negative one upon failure.
		/// EXPORT_API int PluginResetAnimation(int animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginResetAnimation(int animationId);
		/// <summary>
		/// Resume the animation with loop `ON` or `OFF` referenced by id.
		/// EXPORT_API void PluginResumeAnimation(int animationId, bool loop);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginResumeAnimation(int animationId, bool loop);
		/// <summary>
		/// Resume the animation with loop `ON` or `OFF` referenced by name.
		/// EXPORT_API void PluginResumeAnimationName(const char* path, bool loop);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginResumeAnimationName(IntPtr path, bool loop);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginResumeAnimationNameD(const char* path, double loop);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginResumeAnimationNameD(IntPtr path, double loop);
		/// <summary>
		/// Reverse the animation frame order of the `Chroma` animation. Returns the 
		/// animation id upon success. Returns negative one upon failure. Animation 
		/// is referenced by id.
		/// EXPORT_API int PluginReverse(int animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginReverse(int animationId);
		/// <summary>
		/// Reverse the animation frame order of the `Chroma` animation. Animation is 
		/// referenced by id.
		/// EXPORT_API void PluginReverseAllFrames(int animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginReverseAllFrames(int animationId);
		/// <summary>
		/// Reverse the animation frame order of the `Chroma` animation. Animation is 
		/// referenced by name.
		/// EXPORT_API void PluginReverseAllFramesName(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginReverseAllFramesName(IntPtr path);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginReverseAllFramesNameD(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginReverseAllFramesNameD(IntPtr path);
		/// <summary>
		/// Save the animation referenced by id to the path specified.
		/// EXPORT_API int PluginSaveAnimation(int animationId, const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginSaveAnimation(int animationId, IntPtr path);
		/// <summary>
		/// Save the named animation to the target path specified.
		/// EXPORT_API int PluginSaveAnimationName(const char* sourceAnimation, const char* targetAnimation);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginSaveAnimationName(IntPtr sourceAnimation, IntPtr targetAnimation);
		/// <summary>
		/// Set the animation color for a frame given the `1D` `led`. The `led` should 
		/// be greater than or equal to 0 and less than the `MaxLeds`. The animation 
		/// is referenced by id.
		/// EXPORT_API void PluginSet1DColor(int animationId, int frameId, int led, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSet1DColor(int animationId, int frameId, int led, int color);
		/// <summary>
		/// Set the animation color for a frame given the `1D` `led`. The `led` should 
		/// be greater than or equal to 0 and less than the `MaxLeds`. The animation 
		/// is referenced by name.
		/// EXPORT_API void PluginSet1DColorName(const char* path, int frameId, int led, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSet1DColorName(IntPtr path, int frameId, int led, int color);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginSet1DColorNameD(const char* path, double frameId, double led, double color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginSet1DColorNameD(IntPtr path, double frameId, double led, double color);
		/// <summary>
		/// Set the animation color for a frame given the `2D` `row` and `column`. The 
		/// `row` should be greater than or equal to 0 and less than the `MaxRow`. 
		/// The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		/// The animation is referenced by id.
		/// EXPORT_API void PluginSet2DColor(int animationId, int frameId, int row, int column, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSet2DColor(int animationId, int frameId, int row, int column, int color);
		/// <summary>
		/// Set the animation color for a frame given the `2D` `row` and `column`. The 
		/// `row` should be greater than or equal to 0 and less than the `MaxRow`. 
		/// The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		/// The animation is referenced by name.
		/// EXPORT_API void PluginSet2DColorName(const char* path, int frameId, int row, int column, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSet2DColorName(IntPtr path, int frameId, int row, int column, int color);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginSet2DColorNameD(const char* path, double frameId, double rowColumnIndex, double color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginSet2DColorNameD(IntPtr path, double frameId, double rowColumnIndex, double color);
		/// <summary>
		/// When custom color is set, the custom key mode will be used. The animation 
		/// is referenced by id.
		/// EXPORT_API void PluginSetChromaCustomColorAllFrames(int animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetChromaCustomColorAllFrames(int animationId);
		/// <summary>
		/// When custom color is set, the custom key mode will be used. The animation 
		/// is referenced by name.
		/// EXPORT_API void PluginSetChromaCustomColorAllFramesName(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetChromaCustomColorAllFramesName(IntPtr path);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginSetChromaCustomColorAllFramesNameD(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginSetChromaCustomColorAllFramesNameD(IntPtr path);
		/// <summary>
		/// Set the Chroma custom key color flag on all frames. `True` changes the layout 
		/// from grid to key. `True` changes the layout from key to grid. Animation 
		/// is referenced by id.
		/// EXPORT_API void PluginSetChromaCustomFlag(int animationId, bool flag);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetChromaCustomFlag(int animationId, bool flag);
		/// <summary>
		/// Set the Chroma custom key color flag on all frames. `True` changes the layout 
		/// from grid to key. `True` changes the layout from key to grid. Animation 
		/// is referenced by name.
		/// EXPORT_API void PluginSetChromaCustomFlagName(const char* path, bool flag);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetChromaCustomFlagName(IntPtr path, bool flag);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginSetChromaCustomFlagNameD(const char* path, double flag);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginSetChromaCustomFlagNameD(IntPtr path, double flag);
		/// <summary>
		/// Set the current frame of the animation referenced by id.
		/// EXPORT_API void PluginSetCurrentFrame(int animationId, int frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetCurrentFrame(int animationId, int frameId);
		/// <summary>
		/// Set the current frame of the animation referenced by name.
		/// EXPORT_API void PluginSetCurrentFrameName(const char* path, int frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetCurrentFrameName(IntPtr path, int frameId);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginSetCurrentFrameNameD(const char* path, double frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginSetCurrentFrameNameD(IntPtr path, double frameId);
		/// <summary>
		/// Set the custom alpha flag on the color array
		/// EXPORT_API RZRESULT PluginSetCustomColorFlag2D(int device, int* colors);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginSetCustomColorFlag2D(int device, int[] colors);
		/// <summary>
		/// Changes the `deviceType` and `device` of a `Chroma` animation. If the device 
		/// is changed, the `Chroma` animation will be reset with 1 blank frame. Returns 
		/// the animation id upon success. Returns negative one upon failure.
		/// EXPORT_API int PluginSetDevice(int animationId, int deviceType, int device);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginSetDevice(int animationId, int deviceType, int device);
		/// <summary>
		/// SetEffect will display the referenced effect id.
		/// EXPORT_API RZRESULT PluginSetEffect(const ChromaSDK::FChromaSDKGuid& effectId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginSetEffect(Guid effectId);
		/// <summary>
		/// SetEffectCustom1D will display the referenced colors immediately
		/// EXPORT_API RZRESULT PluginSetEffectCustom1D(const int device, const int* colors);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginSetEffectCustom1D(int device, int[] colors);
		/// <summary>
		/// SetEffectCustom2D will display the referenced colors immediately
		/// EXPORT_API RZRESULT PluginSetEffectCustom2D(const int device, const int* colors);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginSetEffectCustom2D(int device, int[] colors);
		/// <summary>
		/// SetEffectKeyboardCustom2D will display the referenced custom keyboard colors 
		/// immediately
		/// EXPORT_API RZRESULT PluginSetEffectKeyboardCustom2D(const int device, const int* colors);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginSetEffectKeyboardCustom2D(int device, int[] colors);
		/// <summary>
		/// When the idle animation is used, the named animation will play when no other 
		/// animations are playing. Reference the animation by id.
		/// EXPORT_API void PluginSetIdleAnimation(int animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetIdleAnimation(int animationId);
		/// <summary>
		/// When the idle animation is used, the named animation will play when no other 
		/// animations are playing. Reference the animation by name.
		/// EXPORT_API void PluginSetIdleAnimationName(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetIdleAnimationName(IntPtr path);
		/// <summary>
		/// Set animation key to a static color for the given frame.
		/// EXPORT_API void PluginSetKeyColor(int animationId, int frameId, int rzkey, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeyColor(int animationId, int frameId, int rzkey, int color);
		/// <summary>
		/// Set the key to the specified key color for all frames. Animation is referenced 
		/// by id.
		/// EXPORT_API void PluginSetKeyColorAllFrames(int animationId, int rzkey, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeyColorAllFrames(int animationId, int rzkey, int color);
		/// <summary>
		/// Set the key to the specified key color for all frames. Animation is referenced 
		/// by name.
		/// EXPORT_API void PluginSetKeyColorAllFramesName(const char* path, int rzkey, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeyColorAllFramesName(IntPtr path, int rzkey, int color);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginSetKeyColorAllFramesNameD(const char* path, double rzkey, double color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginSetKeyColorAllFramesNameD(IntPtr path, double rzkey, double color);
		/// <summary>
		/// Set the key to the specified key color for all frames. Animation is referenced 
		/// by id.
		/// EXPORT_API void PluginSetKeyColorAllFramesRGB(int animationId, int rzkey, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeyColorAllFramesRGB(int animationId, int rzkey, int red, int green, int blue);
		/// <summary>
		/// Set the key to the specified key color for all frames. Animation is referenced 
		/// by name.
		/// EXPORT_API void PluginSetKeyColorAllFramesRGBName(const char* path, int rzkey, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeyColorAllFramesRGBName(IntPtr path, int rzkey, int red, int green, int blue);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginSetKeyColorAllFramesRGBNameD(const char* path, double rzkey, double red, double green, double blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginSetKeyColorAllFramesRGBNameD(IntPtr path, double rzkey, double red, double green, double blue);
		/// <summary>
		/// Set animation key to a static color for the given frame.
		/// EXPORT_API void PluginSetKeyColorName(const char* path, int frameId, int rzkey, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeyColorName(IntPtr path, int frameId, int rzkey, int color);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginSetKeyColorNameD(const char* path, double frameId, double rzkey, double color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginSetKeyColorNameD(IntPtr path, double frameId, double rzkey, double color);
		/// <summary>
		/// Set the key to the specified key color for the specified frame. Animation 
		/// is referenced by id.
		/// EXPORT_API void PluginSetKeyColorRGB(int animationId, int frameId, int rzkey, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeyColorRGB(int animationId, int frameId, int rzkey, int red, int green, int blue);
		/// <summary>
		/// Set the key to the specified key color for the specified frame. Animation 
		/// is referenced by name.
		/// EXPORT_API void PluginSetKeyColorRGBName(const char* path, int frameId, int rzkey, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeyColorRGBName(IntPtr path, int frameId, int rzkey, int red, int green, int blue);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginSetKeyColorRGBNameD(const char* path, double frameId, double rzkey, double red, double green, double blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginSetKeyColorRGBNameD(IntPtr path, double frameId, double rzkey, double red, double green, double blue);
		/// <summary>
		/// Set animation key to a static color for the given frame if the existing 
		/// color is not already black.
		/// EXPORT_API void PluginSetKeyNonZeroColor(int animationId, int frameId, int rzkey, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeyNonZeroColor(int animationId, int frameId, int rzkey, int color);
		/// <summary>
		/// Set animation key to a static color for the given frame if the existing 
		/// color is not already black.
		/// EXPORT_API void PluginSetKeyNonZeroColorName(const char* path, int frameId, int rzkey, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeyNonZeroColorName(IntPtr path, int frameId, int rzkey, int color);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginSetKeyNonZeroColorNameD(const char* path, double frameId, double rzkey, double color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginSetKeyNonZeroColorNameD(IntPtr path, double frameId, double rzkey, double color);
		/// <summary>
		/// Set the key to the specified key color for the specified frame where color 
		/// is not black. Animation is referenced by id.
		/// EXPORT_API void PluginSetKeyNonZeroColorRGB(int animationId, int frameId, int rzkey, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeyNonZeroColorRGB(int animationId, int frameId, int rzkey, int red, int green, int blue);
		/// <summary>
		/// Set the key to the specified key color for the specified frame where color 
		/// is not black. Animation is referenced by name.
		/// EXPORT_API void PluginSetKeyNonZeroColorRGBName(const char* path, int frameId, int rzkey, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeyNonZeroColorRGBName(IntPtr path, int frameId, int rzkey, int red, int green, int blue);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginSetKeyNonZeroColorRGBNameD(const char* path, double frameId, double rzkey, double red, double green, double blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginSetKeyNonZeroColorRGBNameD(IntPtr path, double frameId, double rzkey, double red, double green, double blue);
		/// <summary>
		/// Set animation key by row and column to a static color for the given frame. 
		///
		/// EXPORT_API void PluginSetKeyRowColumnColorName(const char* path, int frameId, int row, int column, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeyRowColumnColorName(IntPtr path, int frameId, int row, int column, int color);
		/// <summary>
		/// Set an array of animation keys to a static color for the given frame. Animation 
		/// is referenced by id.
		/// EXPORT_API void PluginSetKeysColor(int animationId, int frameId, const int* rzkeys, int keyCount, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeysColor(int animationId, int frameId, int[] rzkeys, int keyCount, int color);
		/// <summary>
		/// Set an array of animation keys to a static color for all frames. Animation 
		/// is referenced by id.
		/// EXPORT_API void PluginSetKeysColorAllFrames(int animationId, const int* rzkeys, int keyCount, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeysColorAllFrames(int animationId, int[] rzkeys, int keyCount, int color);
		/// <summary>
		/// Set an array of animation keys to a static color for all frames. Animation 
		/// is referenced by name.
		/// EXPORT_API void PluginSetKeysColorAllFramesName(const char* path, const int* rzkeys, int keyCount, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeysColorAllFramesName(IntPtr path, int[] rzkeys, int keyCount, int color);
		/// <summary>
		/// Set an array of animation keys to a static color for all frames. Animation 
		/// is referenced by id.
		/// EXPORT_API void PluginSetKeysColorAllFramesRGB(int animationId, const int* rzkeys, int keyCount, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeysColorAllFramesRGB(int animationId, int[] rzkeys, int keyCount, int red, int green, int blue);
		/// <summary>
		/// Set an array of animation keys to a static color for all frames. Animation 
		/// is referenced by name.
		/// EXPORT_API void PluginSetKeysColorAllFramesRGBName(const char* path, const int* rzkeys, int keyCount, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeysColorAllFramesRGBName(IntPtr path, int[] rzkeys, int keyCount, int red, int green, int blue);
		/// <summary>
		/// Set an array of animation keys to a static color for the given frame.
		/// EXPORT_API void PluginSetKeysColorName(const char* path, int frameId, const int* rzkeys, int keyCount, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeysColorName(IntPtr path, int frameId, int[] rzkeys, int keyCount, int color);
		/// <summary>
		/// Set an array of animation keys to a static color for the given frame. Animation 
		/// is referenced by id.
		/// EXPORT_API void PluginSetKeysColorRGB(int animationId, int frameId, const int* rzkeys, int keyCount, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeysColorRGB(int animationId, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue);
		/// <summary>
		/// Set an array of animation keys to a static color for the given frame. Animation 
		/// is referenced by name.
		/// EXPORT_API void PluginSetKeysColorRGBName(const char* path, int frameId, const int* rzkeys, int keyCount, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeysColorRGBName(IntPtr path, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue);
		/// <summary>
		/// Set an array of animation keys to a static color for the given frame if 
		/// the existing color is not already black.
		/// EXPORT_API void PluginSetKeysNonZeroColor(int animationId, int frameId, const int* rzkeys, int keyCount, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeysNonZeroColor(int animationId, int frameId, int[] rzkeys, int keyCount, int color);
		/// <summary>
		/// Set an array of animation keys to a static color for the given frame where 
		/// the color is not black. Animation is referenced by id.
		/// EXPORT_API void PluginSetKeysNonZeroColorAllFrames(int animationId, const int* rzkeys, int keyCount, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeysNonZeroColorAllFrames(int animationId, int[] rzkeys, int keyCount, int color);
		/// <summary>
		/// Set an array of animation keys to a static color for all frames if the existing 
		/// color is not already black. Reference animation by name.
		/// EXPORT_API void PluginSetKeysNonZeroColorAllFramesName(const char* path, const int* rzkeys, int keyCount, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeysNonZeroColorAllFramesName(IntPtr path, int[] rzkeys, int keyCount, int color);
		/// <summary>
		/// Set an array of animation keys to a static color for the given frame if 
		/// the existing color is not already black. Reference animation by name.
		/// EXPORT_API void PluginSetKeysNonZeroColorName(const char* path, int frameId, const int* rzkeys, int keyCount, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeysNonZeroColorName(IntPtr path, int frameId, int[] rzkeys, int keyCount, int color);
		/// <summary>
		/// Set an array of animation keys to a static color for the given frame where 
		/// the color is not black. Animation is referenced by id.
		/// EXPORT_API void PluginSetKeysNonZeroColorRGB(int animationId, int frameId, const int* rzkeys, int keyCount, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeysNonZeroColorRGB(int animationId, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue);
		/// <summary>
		/// Set an array of animation keys to a static color for the given frame where 
		/// the color is not black. Animation is referenced by name.
		/// EXPORT_API void PluginSetKeysNonZeroColorRGBName(const char* path, int frameId, const int* rzkeys, int keyCount, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeysNonZeroColorRGBName(IntPtr path, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue);
		/// <summary>
		/// Set an array of animation keys to a static color for the given frame where 
		/// the color is black. Animation is referenced by id.
		/// EXPORT_API void PluginSetKeysZeroColor(int animationId, int frameId, const int* rzkeys, int keyCount, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeysZeroColor(int animationId, int frameId, int[] rzkeys, int keyCount, int color);
		/// <summary>
		/// Set an array of animation keys to a static color for all frames where the 
		/// color is black. Animation is referenced by id.
		/// EXPORT_API void PluginSetKeysZeroColorAllFrames(int animationId, const int* rzkeys, int keyCount, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeysZeroColorAllFrames(int animationId, int[] rzkeys, int keyCount, int color);
		/// <summary>
		/// Set an array of animation keys to a static color for all frames where the 
		/// color is black. Animation is referenced by name.
		/// EXPORT_API void PluginSetKeysZeroColorAllFramesName(const char* path, const int* rzkeys, int keyCount, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeysZeroColorAllFramesName(IntPtr path, int[] rzkeys, int keyCount, int color);
		/// <summary>
		/// Set an array of animation keys to a static color for all frames where the 
		/// color is black. Animation is referenced by id.
		/// EXPORT_API void PluginSetKeysZeroColorAllFramesRGB(int animationId, const int* rzkeys, int keyCount, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeysZeroColorAllFramesRGB(int animationId, int[] rzkeys, int keyCount, int red, int green, int blue);
		/// <summary>
		/// Set an array of animation keys to a static color for all frames where the 
		/// color is black. Animation is referenced by name.
		/// EXPORT_API void PluginSetKeysZeroColorAllFramesRGBName(const char* path, const int* rzkeys, int keyCount, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeysZeroColorAllFramesRGBName(IntPtr path, int[] rzkeys, int keyCount, int red, int green, int blue);
		/// <summary>
		/// Set an array of animation keys to a static color for the given frame where 
		/// the color is black. Animation is referenced by name.
		/// EXPORT_API void PluginSetKeysZeroColorName(const char* path, int frameId, const int* rzkeys, int keyCount, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeysZeroColorName(IntPtr path, int frameId, int[] rzkeys, int keyCount, int color);
		/// <summary>
		/// Set an array of animation keys to a static color for the given frame where 
		/// the color is black. Animation is referenced by id.
		/// EXPORT_API void PluginSetKeysZeroColorRGB(int animationId, int frameId, const int* rzkeys, int keyCount, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeysZeroColorRGB(int animationId, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue);
		/// <summary>
		/// Set an array of animation keys to a static color for the given frame where 
		/// the color is black. Animation is referenced by name.
		/// EXPORT_API void PluginSetKeysZeroColorRGBName(const char* path, int frameId, const int* rzkeys, int keyCount, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeysZeroColorRGBName(IntPtr path, int frameId, int[] rzkeys, int keyCount, int red, int green, int blue);
		/// <summary>
		/// Set animation key to a static color for the given frame where the color 
		/// is black. Animation is referenced by id.
		/// EXPORT_API void PluginSetKeyZeroColor(int animationId, int frameId, int rzkey, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeyZeroColor(int animationId, int frameId, int rzkey, int color);
		/// <summary>
		/// Set animation key to a static color for the given frame where the color 
		/// is black. Animation is referenced by name.
		/// EXPORT_API void PluginSetKeyZeroColorName(const char* path, int frameId, int rzkey, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeyZeroColorName(IntPtr path, int frameId, int rzkey, int color);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginSetKeyZeroColorNameD(const char* path, double frameId, double rzkey, double color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginSetKeyZeroColorNameD(IntPtr path, double frameId, double rzkey, double color);
		/// <summary>
		/// Set animation key to a static color for the given frame where the color 
		/// is black. Animation is referenced by id.
		/// EXPORT_API void PluginSetKeyZeroColorRGB(int animationId, int frameId, int rzkey, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeyZeroColorRGB(int animationId, int frameId, int rzkey, int red, int green, int blue);
		/// <summary>
		/// Set animation key to a static color for the given frame where the color 
		/// is black. Animation is referenced by name.
		/// EXPORT_API void PluginSetKeyZeroColorRGBName(const char* path, int frameId, int rzkey, int red, int green, int blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetKeyZeroColorRGBName(IntPtr path, int frameId, int rzkey, int red, int green, int blue);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginSetKeyZeroColorRGBNameD(const char* path, double frameId, double rzkey, double red, double green, double blue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginSetKeyZeroColorRGBNameD(IntPtr path, double frameId, double rzkey, double red, double green, double blue);
		/// <summary>
		/// Invokes the setup for a debug logging callback so that `stdout` is redirected 
		/// to the callback. This is used by `Unity` so that debug messages can appear 
		/// in the console window.
		/// EXPORT_API void PluginSetLogDelegate(DebugLogPtr fp);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetLogDelegate(IntPtr fp);
		/// <summary>
		/// Sets the target device to the static color.
		/// EXPORT_API void PluginSetStaticColor(int deviceType, int device, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetStaticColor(int deviceType, int device, int color);
		/// <summary>
		/// Sets all devices to the static color.
		/// EXPORT_API void PluginSetStaticColorAll(int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSetStaticColorAll(int color);
		/// <summary>
		/// Sets the target device to the static color.
		/// EXPORT_API void PluginStaticColor(int deviceType, int device, int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginStaticColor(int deviceType, int device, int color);
		/// <summary>
		/// Sets all devices to the static color.
		/// EXPORT_API void PluginStaticColorAll(int color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginStaticColorAll(int color);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginStaticColorD(double deviceType, double device, double color);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginStaticColorD(double deviceType, double device, double color);
		/// <summary>
		/// `PluginStopAll` will automatically stop all animations that are playing. 
		///
		/// EXPORT_API void PluginStopAll();
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginStopAll();
		/// <summary>
		/// Stops animation playback if in progress. Returns the animation id upon success. 
		/// Returns negative one upon failure.
		/// EXPORT_API int PluginStopAnimation(int animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginStopAnimation(int animationId);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginStopAnimationD(double animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginStopAnimationD(double animationId);
		/// <summary>
		/// `PluginStopAnimationName` automatically handles initializing the `ChromaSDK`. 
		/// The named `.chroma` animation file will be automatically opened. The animation 
		/// will stop if playing.
		/// EXPORT_API void PluginStopAnimationName(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginStopAnimationName(IntPtr path);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginStopAnimationNameD(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginStopAnimationNameD(IntPtr path);
		/// <summary>
		/// `PluginStopAnimationType` automatically handles initializing the `ChromaSDK`. 
		/// If any animation is playing for the `deviceType` and `device` combination, 
		/// it will be stopped.
		/// EXPORT_API void PluginStopAnimationType(int deviceType, int device);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginStopAnimationType(int deviceType, int device);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginStopAnimationTypeD(double deviceType, double device);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginStopAnimationTypeD(double deviceType, double device);
		/// <summary>
		/// `PluginStopComposite` automatically handles initializing the `ChromaSDK`. 
		/// The named animation files for the `.chroma` set will be automatically opened. 
		/// The set of animations will be stopped if playing.
		/// EXPORT_API void PluginStopComposite(const char* name);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginStopComposite(IntPtr name);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginStopCompositeD(const char* name);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginStopCompositeD(IntPtr name);
		/// <summary>
		/// Return color1 - color2
		/// EXPORT_API int PluginSubtractColor(const int color1, const int color2);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginSubtractColor(int color1, int color2);
		/// <summary>
		/// Subtract the source color from the target color for the frame where the 
		/// target color is not black. Source and target are referenced by id.
		/// EXPORT_API void PluginSubtractNonZeroAllKeys(int sourceAnimationId, int targetAnimationId, int frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSubtractNonZeroAllKeys(int sourceAnimationId, int targetAnimationId, int frameId);
		/// <summary>
		/// Subtract the source color from the target color for all frames where the 
		/// target color is not black. Source and target are referenced by id.
		/// EXPORT_API void PluginSubtractNonZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSubtractNonZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
		/// <summary>
		/// Subtract the source color from the target color for all frames where the 
		/// target color is not black. Source and target are referenced by name.
		/// EXPORT_API void PluginSubtractNonZeroAllKeysAllFramesName(const char* sourceAnimation, const char* targetAnimation);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSubtractNonZeroAllKeysAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginSubtractNonZeroAllKeysAllFramesNameD(const char* sourceAnimation, const char* targetAnimation);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginSubtractNonZeroAllKeysAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
		/// <summary>
		/// Subtract the source color from the target color for all frames where the 
		/// target color is not black starting at offset for the length of the source. 
		/// Source and target are referenced by id.
		/// EXPORT_API void PluginSubtractNonZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSubtractNonZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
		/// <summary>
		/// Subtract the source color from the target color for all frames where the 
		/// target color is not black starting at offset for the length of the source. 
		/// Source and target are referenced by name.
		/// EXPORT_API void PluginSubtractNonZeroAllKeysAllFramesOffsetName(const char* sourceAnimation, const char* targetAnimation, int offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSubtractNonZeroAllKeysAllFramesOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int offset);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginSubtractNonZeroAllKeysAllFramesOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginSubtractNonZeroAllKeysAllFramesOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double offset);
		/// <summary>
		/// Subtract the source color from the target color for the frame where the 
		/// target color is not black. Source and target are referenced by name.
		/// EXPORT_API void PluginSubtractNonZeroAllKeysName(const char* sourceAnimation, const char* targetAnimation, int frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSubtractNonZeroAllKeysName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId);
		/// <summary>
		/// Subtract the source color from the target where color is not black for the 
		/// source frame and target offset frame, reference source and target by id. 
		///
		/// EXPORT_API void PluginSubtractNonZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSubtractNonZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
		/// <summary>
		/// Subtract the source color from the target where color is not black for the 
		/// source frame and target offset frame, reference source and target by name. 
		///
		/// EXPORT_API void PluginSubtractNonZeroAllKeysOffsetName(const char* sourceAnimation, const char* targetAnimation, int frameId, int offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSubtractNonZeroAllKeysOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId, int offset);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginSubtractNonZeroAllKeysOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double frameId, double offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginSubtractNonZeroAllKeysOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId, double offset);
		/// <summary>
		/// Subtract the source color from the target color where the target color is 
		/// not black for all frames. Reference source and target by id.
		/// EXPORT_API void PluginSubtractNonZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSubtractNonZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
		/// <summary>
		/// Subtract the source color from the target color where the target color is 
		/// not black for all frames. Reference source and target by name.
		/// EXPORT_API void PluginSubtractNonZeroTargetAllKeysAllFramesName(const char* sourceAnimation, const char* targetAnimation);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSubtractNonZeroTargetAllKeysAllFramesName(IntPtr sourceAnimation, IntPtr targetAnimation);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginSubtractNonZeroTargetAllKeysAllFramesNameD(const char* sourceAnimation, const char* targetAnimation);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginSubtractNonZeroTargetAllKeysAllFramesNameD(IntPtr sourceAnimation, IntPtr targetAnimation);
		/// <summary>
		/// Subtract the source color from the target color where the target color is 
		/// not black for all frames starting at the target offset for the length of 
		/// the source. Reference source and target by id.
		/// EXPORT_API void PluginSubtractNonZeroTargetAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSubtractNonZeroTargetAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
		/// <summary>
		/// Subtract the source color from the target color where the target color is 
		/// not black for all frames starting at the target offset for the length of 
		/// the source. Reference source and target by name.
		/// EXPORT_API void PluginSubtractNonZeroTargetAllKeysAllFramesOffsetName(const char* sourceAnimation, const char* targetAnimation, int offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSubtractNonZeroTargetAllKeysAllFramesOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int offset);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginSubtractNonZeroTargetAllKeysAllFramesOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginSubtractNonZeroTargetAllKeysAllFramesOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double offset);
		/// <summary>
		/// Subtract the source color from the target color where the target color is 
		/// not black from the source frame to the target offset frame. Reference source 
		/// and target by id.
		/// EXPORT_API void PluginSubtractNonZeroTargetAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSubtractNonZeroTargetAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
		/// <summary>
		/// Subtract the source color from the target color where the target color is 
		/// not black from the source frame to the target offset frame. Reference source 
		/// and target by name.
		/// EXPORT_API void PluginSubtractNonZeroTargetAllKeysOffsetName(const char* sourceAnimation, const char* targetAnimation, int frameId, int offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSubtractNonZeroTargetAllKeysOffsetName(IntPtr sourceAnimation, IntPtr targetAnimation, int frameId, int offset);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginSubtractNonZeroTargetAllKeysOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double frameId, double offset);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginSubtractNonZeroTargetAllKeysOffsetNameD(IntPtr sourceAnimation, IntPtr targetAnimation, double frameId, double offset);
		/// <summary>
		/// Subtract all frames with the min RGB color where the animation color is 
		/// less than the min threshold AND with the max RGB color where the animation 
		/// is more than the max threshold. Animation is referenced by id.
		/// EXPORT_API void PluginSubtractThresholdColorsMinMaxAllFramesRGB(const int animationId, const int minThreshold, const int minRed, const int minGreen, const int minBlue, const int maxThreshold, const int maxRed, const int maxGreen, const int maxBlue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSubtractThresholdColorsMinMaxAllFramesRGB(int animationId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue);
		/// <summary>
		/// Subtract all frames with the min RGB color where the animation color is 
		/// less than the min threshold AND with the max RGB color where the animation 
		/// is more than the max threshold. Animation is referenced by name.
		/// EXPORT_API void PluginSubtractThresholdColorsMinMaxAllFramesRGBName(const char* path, const int minThreshold, const int minRed, const int minGreen, const int minBlue, const int maxThreshold, const int maxRed, const int maxGreen, const int maxBlue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSubtractThresholdColorsMinMaxAllFramesRGBName(IntPtr path, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginSubtractThresholdColorsMinMaxAllFramesRGBNameD(const char* path, double minThreshold, double minRed, double minGreen, double minBlue, double maxThreshold, double maxRed, double maxGreen, double maxBlue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginSubtractThresholdColorsMinMaxAllFramesRGBNameD(IntPtr path, double minThreshold, double minRed, double minGreen, double minBlue, double maxThreshold, double maxRed, double maxGreen, double maxBlue);
		/// <summary>
		/// Subtract the specified frame with the min RGB color where the animation 
		/// color is less than the min threshold AND with the max RGB color where the 
		/// animation is more than the max threshold. Animation is referenced by id. 
		///
		/// EXPORT_API void PluginSubtractThresholdColorsMinMaxRGB(const int animationId, const int frameId, const int minThreshold, const int minRed, const int minGreen, const int minBlue, const int maxThreshold, const int maxRed, const int maxGreen, const int maxBlue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSubtractThresholdColorsMinMaxRGB(int animationId, int frameId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue);
		/// <summary>
		/// Subtract the specified frame with the min RGB color where the animation 
		/// color is less than the min threshold AND with the max RGB color where the 
		/// animation is more than the max threshold. Animation is referenced by name. 
		///
		/// EXPORT_API void PluginSubtractThresholdColorsMinMaxRGBName(const char* path, const int frameId, const int minThreshold, const int minRed, const int minGreen, const int minBlue, const int maxThreshold, const int maxRed, const int maxGreen, const int maxBlue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginSubtractThresholdColorsMinMaxRGBName(IntPtr path, int frameId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginSubtractThresholdColorsMinMaxRGBNameD(const char* path, const int frameId, const int minThreshold, const int minRed, const int minGreen, const int minBlue, const int maxThreshold, const int maxRed, const int maxGreen, const int maxBlue);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginSubtractThresholdColorsMinMaxRGBNameD(IntPtr path, int frameId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue);
		/// <summary>
		/// Trim the end of the animation. The length of the animation will be the lastFrameId 
		/// plus one. Reference the animation by id.
		/// EXPORT_API void PluginTrimEndFrames(int animationId, int lastFrameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginTrimEndFrames(int animationId, int lastFrameId);
		/// <summary>
		/// Trim the end of the animation. The length of the animation will be the lastFrameId 
		/// plus one. Reference the animation by name.
		/// EXPORT_API void PluginTrimEndFramesName(const char* path, int lastFrameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginTrimEndFramesName(IntPtr path, int lastFrameId);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginTrimEndFramesNameD(const char* path, double lastFrameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginTrimEndFramesNameD(IntPtr path, double lastFrameId);
		/// <summary>
		/// Remove the frame from the animation. Reference animation by id.
		/// EXPORT_API void PluginTrimFrame(int animationId, int frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginTrimFrame(int animationId, int frameId);
		/// <summary>
		/// Remove the frame from the animation. Reference animation by name.
		/// EXPORT_API void PluginTrimFrameName(const char* path, int frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginTrimFrameName(IntPtr path, int frameId);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginTrimFrameNameD(const char* path, double frameId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginTrimFrameNameD(IntPtr path, double frameId);
		/// <summary>
		/// Trim the start of the animation starting at frame 0 for the number of frames. 
		/// Reference the animation by id.
		/// EXPORT_API void PluginTrimStartFrames(int animationId, int numberOfFrames);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginTrimStartFrames(int animationId, int numberOfFrames);
		/// <summary>
		/// Trim the start of the animation starting at frame 0 for the number of frames. 
		/// Reference the animation by name.
		/// EXPORT_API void PluginTrimStartFramesName(const char* path, int numberOfFrames);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginTrimStartFramesName(IntPtr path, int numberOfFrames);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginTrimStartFramesNameD(const char* path, double numberOfFrames);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginTrimStartFramesNameD(IntPtr path, double numberOfFrames);
		/// <summary>
		/// Uninitializes the `ChromaSDK`. Returns 0 upon success. Returns negative 
		/// one upon failure.
		/// EXPORT_API RZRESULT PluginUninit();
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginUninit();
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginUninitD();
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginUninitD();
		/// <summary>
		/// Unloads `Chroma` effects to free up resources. Returns the animation id 
		/// upon success. Returns negative one upon failure. Reference the animation 
		/// by id.
		/// EXPORT_API int PluginUnloadAnimation(int animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginUnloadAnimation(int animationId);
		/// <summary>
		/// D suffix for limited data types.
		/// EXPORT_API double PluginUnloadAnimationD(double animationId);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern double PluginUnloadAnimationD(double animationId);
		/// <summary>
		/// Unload the animation effects. Reference the animation by name.
		/// EXPORT_API void PluginUnloadAnimationName(const char* path);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginUnloadAnimationName(IntPtr path);
		/// <summary>
		/// Unload the the composite set of animation effects. Reference the animation 
		/// by name.
		/// EXPORT_API void PluginUnloadComposite(const char* name);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginUnloadComposite(IntPtr name);
		/// <summary>
		/// Unload the Razer Chroma SDK Library before exiting the application.
		/// EXPORT_API void PluginUnloadLibrarySDK();
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginUnloadLibrarySDK();
		/// <summary>
		/// Unload the Razer Chroma Streaming Plugin Library before exiting the application. 
		///
		/// EXPORT_API void PluginUnloadLibraryStreamingPlugin();
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginUnloadLibraryStreamingPlugin();
		/// <summary>
		/// Updates the `frameIndex` of the `Chroma` animation and sets the `duration` 
		/// (in seconds). The `color` is expected to be an array of the dimensions 
		/// for the `deviceType/device`. The `length` parameter is the size of the 
		/// `color` array. For `EChromaSDKDevice1DEnum` the array size should be `MAX 
		/// LEDS`. For `EChromaSDKDevice2DEnum` the array size should be `MAX ROW` 
		/// times `MAX COLUMN`. Returns the animation id upon success. Returns negative 
		/// one upon failure.
		/// EXPORT_API int PluginUpdateFrame(int animationId, int frameIndex, float duration, int* colors, int length);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginUpdateFrame(int animationId, int frameIndex, float duration, int[] colors, int length);
		/// <summary>
		/// Updates the `frameIndex` of the `Chroma` animation and sets the `duration` 
		/// (in seconds). The `color` is expected to be an array of the dimensions 
		/// for the `deviceType/device`. The `length` parameter is the size of the 
		/// `color` array. For `EChromaSDKDevice1DEnum` the array size should be `MAX 
		/// LEDS`. For `EChromaSDKDevice2DEnum` the array size should be `MAX ROW` 
		/// times `MAX COLUMN`. Returns the animation id upon success. Returns negative 
		/// one upon failure.
		/// EXPORT_API int PluginUpdateFrameName(const char* path, int frameIndex, float duration, int* colors, int length);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern int PluginUpdateFrameName(IntPtr path, int frameIndex, float duration, int[] colors, int length);
		/// <summary>
		/// When the idle animation flag is true, when no other animations are playing, 
		/// the idle animation will be used. The idle animation will not be affected 
		/// by the API calls to PluginIsPlaying, PluginStopAnimationType, PluginGetPlayingAnimationId, 
		/// and PluginGetPlayingAnimationCount. Then the idle animation flag is false, 
		/// the idle animation is disabled. `Device` uses `EChromaSDKDeviceEnum` enums. 
		///
		/// EXPORT_API void PluginUseIdleAnimation(int device, bool flag);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginUseIdleAnimation(int device, bool flag);
		/// <summary>
		/// Set idle animation flag for all devices.
		/// EXPORT_API void PluginUseIdleAnimations(bool flag);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginUseIdleAnimations(bool flag);
		/// <summary>
		/// Set preloading animation flag, which is set to true by default. Reference 
		/// animation by id.
		/// EXPORT_API void PluginUsePreloading(int animationId, bool flag);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginUsePreloading(int animationId, bool flag);
		/// <summary>
		/// Set preloading animation flag, which is set to true by default. Reference 
		/// animation by name.
		/// EXPORT_API void PluginUsePreloadingName(const char* path, bool flag);
		/// </summary>
		[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
		private static extern void PluginUsePreloadingName(IntPtr path, bool flag);
		#endregion
  }
}
