using Excecao;

namespace Criptografar
{
    /// <summary>
    /// Classe para decriptar a connection string
    /// </summary>
    public static class CriptografiaConnectionString
    {
        public static string DecriptarConnectionString(string aConnection)
        {
            string retorno;

            if (string.IsNullOrEmpty(aConnection))
                throw new ErroConStringExcecao();

            retorno = Criptografia.Decrypt(aConnection);

            return retorno;
        }
    }
}