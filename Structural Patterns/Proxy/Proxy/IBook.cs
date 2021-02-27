using System;

namespace Proxy
{
    interface IBook : IDisposable
    {
        Page GetPage(int number);
    }
}
