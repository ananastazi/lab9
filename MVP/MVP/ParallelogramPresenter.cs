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
        private readonly IParallelogramModel model;

        public ParallelogramPresenter(IParallelogramView view, IParallelogramModel model)
        {
            this.view = view;
            this.model = model;
        }

        public void LoadParallelogramHeight(double a, double b, double angle)
        {
            var parallelogram = new Parallelogram(a, b, angle);
            view.SetHeight(parallelogram.calculateHeight());
        }

        public void LoadParallelogramSquare(double a, double b, double angle)
        {
            var parallelogram = new Parallelogram(a, b, angle);
            view.SetSquare(parallelogram.calculateSquare());
        }
    }
}
