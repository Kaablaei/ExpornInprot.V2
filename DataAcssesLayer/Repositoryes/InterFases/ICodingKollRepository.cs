﻿using Domain;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcssesLayer.Repositoryes.InterFases
{
    public interface ICodingKollRepository
    {
        public void Add(CodeingKoll codeingKoll);
        public CodeingKoll GetByCodeKoll(int CodeKoll);

        public List<CodeingKoll> GetAll();

        public void Edit(CodeingKoll codeingKoll);

    }

    public class CodeKollRepository : BaseRepository<CodeingKoll>, ICodingKollRepository
    {
        public CodeKollRepository(AppDbcontext context) : base(context)
        {

        }

        public void Edit(CodeingKoll codeingKoll)
        {
            var item = _context.CodeingKoll.SingleOrDefault(p => p.CodeKoll == codeingKoll.CodeKoll);

            item.KollName = codeingKoll.KollName;
            item.Explain = codeingKoll.Explain;
            item.AccoungGrop = codeingKoll.AccoungGrop;
            item.AccountStatuseIsBebtor = codeingKoll.AccountStatuseIsBebtor;

            _context.CodeingKoll.Update(item);
            _context.SaveChanges();
        }

        public CodeingKoll GetByCodeKoll(int CodeKoll)
        {
            return _context.CodeingKoll.SingleOrDefault(p => p.CodeKoll == CodeKoll);
        }
    }
}
