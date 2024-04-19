using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using System.Security.Cryptography;

namespace ASPNetCoreWebApi1.Services
{
    public class SigningAudienceCertificate
    {
        public RSACryptoServiceProvider _rsa;
        public SigningAudienceCertificate()
        {
            _rsa = new RSACryptoServiceProvider();
        }
        public SigningCredentials GetAudienceSigningKey()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"private_key.xml");
            string privateXmlKey = File.ReadAllText(path);
            _rsa.FromXmlString(privateXmlKey);

            return new SigningCredentials(
                key: new RsaSecurityKey(_rsa),
                algorithm: SecurityAlgorithms.RsaSha256);
        }
        public void Dispose()
        {
            _rsa?.Dispose();
        }

    }
}
