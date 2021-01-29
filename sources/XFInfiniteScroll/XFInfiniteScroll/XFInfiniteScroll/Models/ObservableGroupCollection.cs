/*******************************************************************************************
 *Copyright (c) 2021  All Rights Reserved.
 *CLR版本: 4.0.30319.42000
 *机器名称:LAPTOP-QGB306EI
 *公司名称:
 *命名空间:XFInfiniteScroll.Models
 *文件名:ObservableGroupCollection
 *版本号:V1.0.0.0
 *唯一标识:5779cd12-7b3c-4376-96b7-cbf27ed61b2f
 *当前的用户域:LAPTOP-QGB306EI
 *创建人:Administrator
 *电子邮箱:mzyfbz@dingtalk.com
 *创建时间:2021-01-28 19:59:25

 *描述
 *
 *==========================================================================================
 *修改标记
 *修改时间:2021-01-28 19:59:25
 *修改人:Administrator
 *版本号:V1.0.0.0
 *描述:
 *
********************************************************************************************/
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace XFInfiniteScroll.Models
{
    public class ObservableGroupCollection<K, T> : ObservableCollection<T>
    {
        private readonly K _header;
        private IGrouping<string, InfiniteItems> e;

        public ObservableGroupCollection(IGrouping<K, T> group) : base(group)
        {
            _header = group.Key;
        }

        

        public K Header
        {
            get { return _header; }
        }
    }
}
