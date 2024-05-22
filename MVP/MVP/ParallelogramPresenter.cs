using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    class ParallelogramPresenter
    {
        private readonly IParallelogramView view;
        private readonly Parallelogram model;

        public ParallelogramPresenter(IParallelogramView view, Parallelogram model)
        {
            this.view = view;
            this.model = model;
        }

        public void LoadParallelogramHeight(double a, double b, double angle)
        {
            try
            {
                model.SetA(a);
                model.SetB(b);
                model.SetAngle(angle);
                var height = model.calculateHeight();
                view.SetHeight(height);
            }
            catch (Exception ex)
            {
                view.DisplayError(ex.Message);
            }
        }

        public void LoadParallelogramSquare(double a, double b, double angle)
        {
            try
            {
                model.SetA(a);
                model.SetB(b);
                model.SetAngle(angle);
                var square = model.calculateSquare();
                view.SetSquare(square);
            }
            catch (Exception ex)
            {
                view.DisplayError(ex.Message);
            }
        }
    }

}
