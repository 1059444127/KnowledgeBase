﻿using KnowledgeBase.Add.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeBase.Add.IBLL
{
    public partial interface IUserInfoService : IBaseService<UserInfo>
    {
        bool UpdatePwd(UserInfo userInfoModel);
    }
}
