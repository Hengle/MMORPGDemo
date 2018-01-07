﻿namespace XFramework.WebRequest
{
    internal partial class WebRequestManager
    {
        /// <summary>
        /// Web 请求任务的状态。
        /// </summary>
        private enum WebRequestTaskStatus
        {
            /// <summary>
            /// 准备请求。
            /// </summary>
            Todo,

            /// <summary>
            /// 请求中。
            /// </summary>
            Doing,

            /// <summary>
            /// 请求完成。
            /// </summary>
            Done,

            /// <summary>
            /// 请求错误。
            /// </summary>
            Error
        }
    }
}
