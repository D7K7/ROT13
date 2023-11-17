using System;

public class Kata
{
  public static string Rot13(string input)
  {
    Span<char> translation = stackalloc char[input.Length];
    input.AsSpan().CopyTo(translation);
    
    for (int i = 0; i < translation.Length; i++)
    {
        char currentChar = translation[i];
      
        if (char.IsLetter(currentChar))
        {
            char baseChar = char.IsUpper(currentChar) ? 'A' : 'a';
            translation[i] = (char)((((currentChar - baseChar) + 13) % 26) + baseChar);
        }
    }
    
    return translation.ToString();
  }
}