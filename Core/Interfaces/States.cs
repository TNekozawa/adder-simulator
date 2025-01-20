namespace Core.Interfaces
{
    public enum States
    {
        /// <summary>
        /// 初期状態
        /// </summary>
        Unknown,

        /// <summary>
        /// 入力が空白
        /// </summary>
        Empty,

        /// <summary>
        /// 入力が数値ではない
        /// </summary>
        NotNumeric,

        /// <summary>
        /// 入力が二進数ではない
        /// </summary>
        NotBinary,

        /// <summary>
        /// 取り扱い可能な入力
        /// </summary>
        Capable
    }
}
