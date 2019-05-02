namespace Iterator_Merge_Menu
{
    public interface ITerator
    {
        /// <summary>
        /// 用来判断下一个元素是否为空
        /// </summary>
        /// <returns></returns>
        bool HasNext();

        /// <summary>
        /// 用来获取当前元素
        /// </summary>
        /// <returns></returns>
        object Next();
    }
}
