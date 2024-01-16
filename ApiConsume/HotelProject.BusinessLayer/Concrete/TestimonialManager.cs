using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class TestimonialManager:ITestimonialService
    {
        private readonly ITestimonialDal _TestimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _TestimonialDal = testimonialDal;
        }

        public void TDelete(Testimonial t)
        {
            _TestimonialDal.Delete(t);
        }

        public Testimonial TGetByID(int id)
        {
           return _TestimonialDal.GetByID(id);
        }

        public List<Testimonial> TGetList()
        {
            return _TestimonialDal.GetList();
        }

        public void TInsert(Testimonial t)
        {
            _TestimonialDal.Insert(t);
        }

        public void TUpdate(Testimonial t)
        {
            _TestimonialDal.Update(t);
        }
    }
}
