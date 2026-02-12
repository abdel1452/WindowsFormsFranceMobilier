using System;
using System.Security.Cryptography;


public static class PasswordHelper
{
    public static string HashPassword(string password)
    {
        // Création du sel
        byte[] salt = new byte[16];
        using (var rng = new RNGCryptoServiceProvider())
        {
            rng.GetBytes(salt);
        }

        // PBKDF2
        var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
        byte[] hash = pbkdf2.GetBytes(32);

        // Fusion sel + hash
        byte[] hashBytes = new byte[48];
        Array.Copy(salt, 0, hashBytes, 0, 16);
        Array.Copy(hash, 0, hashBytes, 16, 32);

        return Convert.ToBase64String(hashBytes);
    }

    public static bool VerifyPassword(string password, string storedHash)
    {
        byte[] hashBytes = Convert.FromBase64String(storedHash);

        byte[] salt = new byte[16];
        Array.Copy(hashBytes, 0, salt, 0, 16);

        var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
        byte[] hash = pbkdf2.GetBytes(32);

        for (int i = 0; i < 32; i++)
        {
            if (hashBytes[i + 16] != hash[i])
                return false;
        }

        return true;
    }

    public static bool IsHashed(string motDePasse)
    {
        if (string.IsNullOrEmpty(motDePasse)) return false;

        try
        {
            // Ton hash est en Base64 et doit faire exactement 64 caractères
            byte[] bytes = Convert.FromBase64String(motDePasse);
            return bytes.Length == 48; // sel 16 + hash 32
        }
        catch
        {
            return false; // si ce n’est pas un Base64 valide => pas hashé
        }
    }
}
