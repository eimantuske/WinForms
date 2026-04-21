using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class GlobalHotkey : IDisposable
{
    // Windows API funkcijos
    [DllImport("user32.dll")]
    private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

    [DllImport("user32.dll")]
    private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

    // Modifikatorių reikšmės (Flags)
    public const int NOMOD = 0x0000;
    public const int ALT = 0x0001;
    public const int CTRL = 0x0002;
    public const int SHIFT = 0x0004;
    public const int WIN = 0x0008;

    // Windows žinutės kodas
    public const int WM_HOTKEY = 0x0312;

    private int modifier;
    private int key;
    private IntPtr hWnd;
    private int id;

    public GlobalHotkey(int modifier, Keys key, Form form)
    {
        this.modifier = modifier;
        this.key = (int)key;
        this.hWnd = form.Handle;
        this.id = this.GetHashCode(); // Unikalus ID šiam hotkey
    }

    public bool Register()
    {
        return RegisterHotKey(hWnd, id, modifier, key);
    }

    public bool Unregister()
    {
        return UnregisterHotKey(hWnd, id);
    }

    public void Dispose()
    {
        Unregister();
    }
}