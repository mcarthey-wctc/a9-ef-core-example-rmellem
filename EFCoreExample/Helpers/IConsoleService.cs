namespace EFCoreExample.Helpers;

public interface IConsoleService
{
    string ReadLine();
    void WriteLine(string message);
    void Write(string message);
}