﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void AddColor(Color color)
        {
            _colorDal.Add(color);
        }

        public void DeleteColor(Color color)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetColors()
        {
            return _colorDal.GetAll();
        }

        public void UpdateColor(Color color)
        {
            throw new NotImplementedException();
        }
    }
}
