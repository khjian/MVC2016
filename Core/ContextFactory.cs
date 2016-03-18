﻿using System.Runtime.Remoting.Messaging;

namespace Core
{
    /// <summary>
    /// 数据上下文工厂
    /// </summary>
    public class ContextFactory
    {
        /// <summary>
        /// 获取当前线程的数据上下文
        /// </summary>
        /// <returns>数据上下文</returns>
        public static NineskyContext CurrentContext()
        {
            NineskyContext _nContext = CallContext.GetData("NineskyContext") as NineskyContext;
            if (_nContext == null)
            {
                _nContext = new NineskyContext();
                CallContext.SetData("NineskyContext", _nContext);
            }
            return _nContext;
        }
    }
}
