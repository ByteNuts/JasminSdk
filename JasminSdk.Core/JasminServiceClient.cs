using System;
using System.Net.Http;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core
{
    public abstract class JasminServiceClient : IDisposable
    {
        private bool _disposed;
        protected HttpClient JasminClient { get; set; }

        protected JasminServiceClient()
        {
        }

        protected JasminServiceClient(JasminConfig config)
        {
            Constants.Config = config;
        }



        #region Dispose methods

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                if (JasminClient != null)
                    JasminClient.Dispose();

                _disposed = true;
            }
        }

        private void ThrowIfDisposed()
        {
            if (this._disposed)
                throw new ObjectDisposedException(GetType().FullName);
        }

        #endregion

    }
}
