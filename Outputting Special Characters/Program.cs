/* Sometimes you need to output a special character to the screen. Here are some examples:

•   Output Enter to terminate a line.

•   Output a quote mark. (Quotes in C# serve as text delimiters, so they
    must be treated specially.)

•   Output a Unicode character (of course, if your font knows how to draw it).
 */

// Task: write a program that shows how to work with special characters.

// Multiline output
Console.WriteLine("First line\r\nSecond line");

// I prefer specifying "Enter" in more human form
Console.WriteLine("First line" + Environment.NewLine + "Second line");

// Text containing a quote
Console.WriteLine("The letter started so sweet: \"My Darling\"");

// Unicode characters, in this case Greek beta
Console.WriteLine("If the font knows, here is Greek beta: \u03B2");

// Backslashs themselves need to be doubled
Console.WriteLine("path to Desktop on my computer: " + "C:\\Users\\Hills\\Desktop");

// Waiting for Enter
Console.ReadLine();

/* DISCUSSION:
 * 
 * Note the following about this program:

•   In C#, a backslash in text introduces a so-called escape sequence.
    But what if you want to output a backslash? Then you need to double
    it. This is often the case when dealing with file paths in the Windows
    operating system.

•   Console applications will recognize even the simple \n as a line
    terminator (meaning Enter). However, in many other C# programs,
    you need “the whole Enter,” which is signified with \r\n. That is why
    you used it in this program. You also used Environment.NewLine,
    which is definitely the best alternative since it is nicely human
    readable.
 */