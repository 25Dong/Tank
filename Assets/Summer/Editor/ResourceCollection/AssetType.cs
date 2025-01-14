﻿namespace Summer.Editor.ResourceCollection
{
    /// <summary>
    /// 资源类型。
    /// </summary>
    public enum AssetType : byte
    {
        /// <summary>
        /// 未知。
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// 存放资源。
        /// </summary>
        Asset,

        /// <summary>
        /// 存放场景。
        /// </summary>
        Scene,
    }
}
