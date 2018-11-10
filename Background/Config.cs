using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureMail.Operations
{
    public static class ConfigGmail
    {
        public static string JsonContent_Gmail =
        #region Client ID
            "{\"installed\":{" +
            "\"client_id\":\"" +
        #endregion
            "47472405463-seev3upcfpk1s53fs8as85k754vo1tld.apps.googleusercontent.com"
        #region NO_MORE
        #region Project ID
            + "\",\"project_id\":\"" +
        #endregion
            "secure-mail-v4"
        #region Auth_uri
            + "\",\"auth_uri\":\"" +
        #endregion
            "https://accounts.google.com/o/oauth2/auth"
        #region Token_uri
            + "\",\"token_uri\":\"" +
        #endregion
            "https://accounts.google.com/o/oauth2/token"
        #region Auth_provider_x509_cert_url
            + "\",\"auth_provider_x509_cert_url\":\"" +
        #endregion
            "https://www.googleapis.com/oauth2/v1/certs"
        #endregion
        #region Client_secret
            + "\",\"client_secret\":\"" +
        #endregion
            "rxAHw3-WrOx6I6OLxzlBuZFO"
        #region NO_MORE
        #region Redirect_uris
            + "\",\"redirect_uris\":[\"" +
        #endregion
            "urn:ietf:wg:oauth:2.0:oob\",\"http://localhost"
        #region END
           + "\"]}}";
        #endregion
        #endregion
        //// Convert this string to Stream to read at Gmail API
        //public static System.IO.MemoryStream StreamJson = new System.IO.MemoryStream(Encoding.ASCII.GetBytes(JsonContent_Gmail));
    }
}
