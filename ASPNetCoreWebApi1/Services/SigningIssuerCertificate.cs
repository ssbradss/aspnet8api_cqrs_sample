using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using System.Security.Cryptography;

namespace ASPNetCoreWebApi1.Services
{
    public class SigningIssuerCertificate
    {
        public RSACryptoServiceProvider _rsa;
        public SigningIssuerCertificate () {
            _rsa = new RSACryptoServiceProvider();
        }
        public RsaSecurityKey GetIssuerSigningKey()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"public_key.xml");
            string publicXmlKey = File.ReadAllText(path);
            _rsa.FromXmlString(publicXmlKey);

            return new RsaSecurityKey(_rsa);
        }

        public void Dispose()
        {
            _rsa?.Dispose();
        }

        public SigningCredentials GetAudienceSigningKey()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"public_key.xml");
            string privateXmlKey = File.ReadAllText(path);
            _rsa.FromXmlString(privateXmlKey);

            return new SigningCredentials(
                key: new RsaSecurityKey(_rsa),
                algorithm: SecurityAlgorithms.RsaSha256);
        }
    }
}
