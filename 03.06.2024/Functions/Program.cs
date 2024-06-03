Console.WriteLine("Adinizi daxil edin");
string firstname = Console.ReadLine();

Console.WriteLine("Soyadinizi daxil edin");
string lastname = Console.ReadLine();

Console.WriteLine("Isteye gore domain daxil edin");
string? domain = Console.ReadLine();

firstname = clearText(firstname);
lastname = clearText(lastname);
domain = clearText(domain);

firstname = Capitalize(firstname);
lastname = DoUpper(lastname);
lastname = Replace(lastname);


string email = createEmail(firstname, lastname, domain);
Console.WriteLine(email);


string Capitalize(string text)
{
    string newstr = String.Empty;
    for (int i = 0; i < text.Length; i++)
    {
        int ascicode = (int)text[i];
        if (i == 0)
        {
            if (ascicode >= 97 && ascicode <= 122)
            {
                ascicode -= 32;
            }
        }
        else if (ascicode >= 65 && ascicode <= 90)
        {
            ascicode += 32;
        }
        newstr += (char)ascicode;
    }

    return newstr;
}

string DoUpper(string text)
{
    string newstr = String.Empty;
    for (int i = 0; i < text.Length; i++)
    {
        int ascicode = (int)text[i];
        if (ascicode >= 97 && ascicode <= 122)
        {
            ascicode -= 32;
        }
        newstr += (char)ascicode;
    }

    return newstr;
}

string Replace(string text)
{
    string newstr = String.Empty;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == 'A')
        {
            newstr += 'E';
        }
        else
        {
            newstr += text[i];
        }
    }

    return newstr;
}

string createEmail(string firstname, string lastname, string domain)
{
    if (domain == "") domain = "code.edu.az";
    string email = $"{firstname}.{lastname}@{domain}";

    return email;
}

string clearText(string text)
{
    for (int i = 32; i < 65; i++)
    {
        text = text.Replace($"{(char)i}", "");
    }
    for (int i = 91; i < 97; i++)
    {
        text = text.Replace($"{(char)i}", "");
    }
    for (int i = 123; i < 127; i++)
    {
        text = text.Replace($"{(char)i}", "");
    }
    return text;
}