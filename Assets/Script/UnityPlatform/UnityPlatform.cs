using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MinorShift.Emuera 
{
    public class Color
    {
        public int R;
        public int G;
        public int B;

        Color(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }
        public static Color FromArgb(int r, int g, int b)
        {
            return new Color(r, g, b);
        }
        public static Color Black = new Color(0, 0, 0);

    }
    //using Color = UnityEngine.Color32;
    public class FontStyle
    {
        public static FontStyle Regular;
    }
    public class Font
    {
        public void Dispose()
        { }
    }
    public class MessageBox
    {
        public static void Show(string msg, string title)
        {

        }
        public static void Show(string msg)
        {

        }

    }
    public class Form : System.IDisposable
    {
        protected override void Dispose(bool disposing)
        {
        }
        
        public void Close()
        {

        }

    }
    public class _Application
    {
        public static void Run(System.IDisposable win)
        {

        }
    }
    public class Graphics
    {

     
    
         public void DrawImage(Bitmap b, Rectangle rect, Rectangle r, int Pixel)
        {
    	    throw new NotImplementedException();
        }

         public void FillRectangle(Brush brush, Rectangle rect)
         {
             throw new NotImplementedException();
         }

    }
    public class Point
    {
        public Point(int a, int b)
        { }
    }
    public class GraphicsUnit{
        public static int Pixel;
    }
    public class PictureBox
    {

    }
    
    public class VScrollBar
    {

    }
    public class RichTextBox
    {

    }
    public class ToolTip
    {

    }
    public class Message
    {
        
    }
    public enum DialogResult
    {
        OK,
    }
    public enum ControlStyles
    {
        Opaque,
        UserPaint,
        OptimizedDoubleBuffer,
        AllPaintingInWmPaint,
        ResizeRedraw,
    }
    public enum Keys
    {
        A	, //A 键。
        Add	, //加号键。
        Alt	, //ALT 修改键。
        Apps	, //应用程序密钥 (Microsoft Natural Keyboard)。
        Attn	, //ATTN 键。
        B	, //B 键。
        Back	, //BACKSPACE 键。
        BrowserBack	, //浏览器后退键 (Windows 2000 或更高版本)。
        BrowserFavorites	, //浏览器收藏键 (Windows 2000 或更高版本)。
        BrowserForward	, //浏览器前进键 (Windows 2000 或更高版本)。
        BrowserHome	, //浏览器主页键 (Windows 2000 或更高版本)。
        BrowserRefresh	, //浏览器刷新键 (Windows 2000 或更高版本)。
        BrowserSearch	, //浏览器搜索键 (Windows 2000 或更高版本)。
        BrowserStop	, //浏览器停止键 (Windows 2000 或更高版本)。
        C	, //C 键。
        Cancel	, //CANCEL 键。
        Capital	, //CAPS LOCK 键。
        CapsLock	, //CAPS LOCK 键。
        Clear	, //CLEAR 键。
        Control	, //CTRL 修改键。
        ControlKey	, //CTRL 键。
        Crsel	, //CRSEL 键。
        D	, //D 键。
        D0	, //0 键。
        D1	, //1 键。
        D2	, //2 键。
        D3	, //3 键。
        D4	, //4 键。
        D5	, //5 键。
        D6	, //6 键。
        D7	, //7 键。
        D8	, //8 键。
        D9	, //9 键。
        Decimal	, //句点键。
        Delete	, //DEL 键。
        Divide	, //除号键。
        Down	, //DOWN ARROW 键。
        E	, //E 键。
        End	, //END 键。
        Enter	, //ENTER 键。
        EraseEof	, //ERASE EOF 键。
        Escape	, //ESC 键。
        Execute	, //EXECUTE 键。
        Exsel	, //EXSEL 键。
        F	, //F 键。
        F1	, //F1 键。
        F10	, //F10 键。
        F11	, //F11 键。
        F12	, //F12 键。
        F13	, //F13 键。
        F14	, //F14 键。
        F15	, //F15 键。
        F16	, //F16 键。
        F17	, //F17 键。
        F18	, //F18 键。
        F19	, //F19 键。
        F2	, //F2 键。
        F20	, //F20 键。
        F21	, //F21 键。
        F22	, //F22 键。
        F23	, //F23 键。
        F24	, //F24 键。
        F3	, //F3 键。
        F4	, //F4 键。
        F5	, //F5 键。
        F6	, //F6 键。
        F7	, //F7 键。
        F8	, //F8 键。
        F9	, //F9 键。
        FinalMode	, //IME 最终模式键。
        G	, //G 键。
        H	, //H 键。
        HanguelMode	, //IME Hanguel 模式键。 (保留为了兼容; 使用HangulMode), //HangulMode	, //IME Hangul 模式键。
        HanjaMode	, //IME Hanja 模式键。
        Help	, //HELP 键。
        Home	, //HOME 键。
        I	, //I 键。
        IMEAccept	, //IME 接受密钥，替换IMEAceept。
        IMEAceept	, //IME 接受密钥。 已过时，请IMEAccept相反。
        IMEConvert	, //IME convert 键。
        IMEModeChange	, //IME 模式更改密钥。
        IMENonconvert	, //IME nonconvert 键。
        Insert	, //INS 键。
        J	, //J 键。
        JunjaMode	, //IME Junja 模式键。
        K	, //K 键。
        KanaMode	, //IME Kana 模式键。
        KanjiMode	, //IME Kanji 模式键。
        KeyCode	, //从一个密钥值中提取键代码的位屏蔽。
        L	, //L 键。
        LaunchApplication1	, //启动应用程序一个键 (Windows 2000 或更高版本)。
        LaunchApplication2	, //启动应用程序两个键 (Windows 2000 或更高版本)。
        LaunchMail	, //启动邮件键 (Windows 2000 或更高版本)。
        LButton	, //鼠标左键。
        LControlKey	, //左 CTRL 键。
        Left	, //LEFT ARROW 键。
        LineFeed	, //LINEFEED 键。
        LMenu	, //左 ALT 键。
        LShiftKey	, //左的 SHIFT 键。
        LWin	, //左 Windows 徽标键 (Microsoft Natural Keyboard)。
        M	, //M 键。
        MButton	, //鼠标中键 （三个按钮的鼠标）。
        MediaNextTrack	, //媒体下一曲目键 (Windows 2000 或更高版本)。
        MediaPlayPause	, //在媒体播放暂停键 (Windows 2000 或更高版本)。
        MediaPreviousTrack	, //媒体上一曲目键 (Windows 2000 或更高版本)。
        MediaStop	, //媒体停止键 (Windows 2000 或更高版本)。
        Menu	, //ALT 键。
        Modifiers	, //若要从一个密钥值中提取修饰符位掩码。
        Multiply	, //乘号键。
        N	, //N 键。
        Next	, //PAGE DOWN 键。
        NoName	, //留待将来使用的常数。
        None	, //不按任何键。
        NumLock	, //NUM LOCK 键。
        NumPad0	, //数字键盘上的 0 键。
        NumPad1	, //数字键盘上的 1 键。
        NumPad2	, //数字键盘上的 2 键。
        NumPad3	, //数字键盘上的 3 键。
        NumPad4	, //数字键盘上的 4 键。
        NumPad5	, //数字键盘上的 5 键。
        NumPad6	, //数字键盘上的 6 键。
        NumPad7	, //数字键盘上的 7 键。
        NumPad8	, //数字键盘上的 8 键。
        NumPad9	, //数字键盘上的 9 键。
        O	, //O 键。
        Oem1	, //OEM 1 键。
        Oem102	, //OEM 102 键。
        Oem2	, //OEM 2 键。
        Oem3	, //OEM 3 键。
        Oem4	, //OEM 4 键。
        Oem5	, //OEM 5 键。
        Oem6	, //OEM 6 键。
        Oem7	, //OEM 7 键。
        Oem8	, //OEM 8 键。
        OemBackslash	, //OEM 尖括号或 RT 102 键键盘 (Windows 2000 或更高版本) 上的反斜杠键。
        OemClear	, //CLEAR 键。
        OemCloseBrackets	, //美国标准键盘 (Windows 2000 或更高版本) 上的 OEM 右大括号键。
        Oemcomma	, //任何国家/地区键盘 (Windows 2000 或更高版本) 上的 OEM 逗号键。
        OemMinus	, //OEM 减号键 (Windows 2000 或更高版本) 任何国家/地区键盘上。
        OemOpenBrackets	, //美国标准键盘 (Windows 2000 或更高版本) 上的 OEM 左大括号键。
        OemPeriod	, //任何国家/地区键盘 (Windows 2000 或更高版本) 上的 OEM 期间键。
        OemPipe	, //美国标准键盘 (Windows 2000 或更高版本) 上的 OEM 管道键。
        Oemplus	, //OEM 加上任何国家/地区键盘 (Windows 2000 或更高版本) 上的密钥。
        OemQuestion	, //美国标准键盘 (Windows 2000 或更高版本) 上的 OEM 问号键。
        OemQuotes	, //OEM 意见/双精度型引号密钥美国标准键盘 (Windows 2000 或更高版本) 上。
        OemSemicolon	, //美国标准键盘 (Windows 2000 或更高版本) 上的 OEM 分号键。
        Oemtilde	, //美国标准键盘 (Windows 2000 或更高版本) 上的 OEM 颚化符键。
        P	, //P 键。
        Pa1	, //PA1 键。
        Packet	, //用于传递 Unicode 字符，就像它们是击键一样。 Packet 键值是用于非键盘输入方法的 32 位虚拟密钥值的低位字。
        PageDown	, //PAGE DOWN 键。
        PageUp	, //PAGE UP 键。
        Pause	, //PAUSE 键。
        Play	, //播放键。
        Print	, //PRINT 键。
        PrintScreen	, //PRINT SCREEN 键。
        Prior	, //PAGE UP 键。
        ProcessKey	, //PROCESS 键键中。
        Q	, //Q 键。
        R	, //R 键。
        RButton	, //鼠标右键按钮中。
        RControlKey	, //右 CTRL 键。
        Return	, //RETURN 键。
        Right	, //RIGHT ARROW 键。
        RMenu	, //右 ALT 键。
        RShiftKey	, //右 SHIFT 键。
        RWin	, //右 Windows 徽标键 (Microsoft Natural Keyboard)。
        S	, //S 键。
        Scroll	, //SCROLL LOCK 键。
        Select	, //SELECT 键。
        SelectMedia	, //选择媒体键 (Windows 2000 或更高版本) 中。
        Separator	, //分隔符键。
        Shift	, //SHIFT 修改键。
        ShiftKey	, //SHIFT 键。
        Sleep	, //计算机休眠键。
        Snapshot	, //PRINT SCREEN 键。
        Space	, //SPACEBAR 键。
        Subtract	, //减号键。
        T	, //T 键。
        Tab	, //TAB 键。
        U	, //U 键。
        Up	, //UP ARROW 键。
        V	, //V 键。
        VolumeDown	, //音量降低键 (Windows 2000 或更高版本)。
        VolumeMute	, //卷静音键 (Windows 2000 或更高版本)。
        VolumeUp	, //音量增大键 (Windows 2000 或更高版本)。
        W	, //W 键。
        X	, //X 键。
        XButton1	, //第一个 x 鼠标按钮 （五个按钮的鼠标）。
        XButton2	, //第二个鼠标按钮 （五个按钮的鼠标） x。
        Y	, //Y 键。
        Z	, //Z 键。
        Zoom	, //缩放键。
    }
    public enum MouseButtons
    {
        Left,
        Right,
    }
    public class Size
    {
        int H;
        int W;
        public Size(int winWidth, int winHeight)
        {
            H = winHeight;
            W = winWidth;
        }
    }
    public class Program
    {
        public static string ExeDir;
        public static string ErbDir;
        public static string CsvDir;
        public static string DebugDir;

        public static bool DebugMode = false;
    }
    public class Rectangle
    {
        public int Height;
        public int Width;
        public int X;
        public int Y;
    }
    public class RectangleF : Rectangle
    {

    }
};

namespace MinorShift.Emuera.Forms
{
    class MouseEventArgs
    {
        public MouseButtons Button;
        public Point Location;
    }
    delegate void MouseEventHandler(object sender, Forms.MouseEventArgs e);

}