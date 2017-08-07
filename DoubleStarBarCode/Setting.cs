using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoubleStarBarCode
{
    public class Setting
    {
        /// <summary>
        /// 端口
        /// </summary>
        public string COM { get; set; }
        /// <summary>
        /// 字符串or16进制
        /// </summary>
        public string StringOrHex { get; set; }
        /// <summary>
        /// 波特率
        /// </summary>
        public string baudRate { get; set; }
        /// <summary>
        /// 数据位
        /// </summary>
        public string dataBits { get; set; }
        /// <summary>
        /// 停止位
        /// </summary>
        public string stopBits { get; set; }
        /// <summary>
        /// 校验位
        /// </summary>
        public string parity { get; set; }

        public string handshaking { get; set; }
    }
}
