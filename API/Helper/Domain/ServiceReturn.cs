using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace API.Helper.Domain
{
    public class ServiceReturn<TData>
    {
        public ServiceReturn(int count, TData data)
        {
            Count = count;
            Data = data;
            Errors = new List<Error>();
        }
        public ServiceReturn(int count, TData data, List<Error> errors)
        {
            Count = count;
            Data = data;
            Errors = new List<Error>();
            Errors.AddRange(errors.ToList());
        }

        public int PageCount { get; set; }
        public int Count { get; set; }

        public ServiceReturn()
        {
            Errors = new List<Error>();
        }

        public ServiceReturn(List<Error> errors)
        {
            Errors = errors.ToList();
        }

        public TData Data { get; set; }
        public List<Error> Errors { get; set; }

        public bool HasErrors
        {
            get { return Errors.Count > 0; }
        }

        public void AddError(Error error)
        {
            Errors.Add(error);
        }

        public void AddError(string error)
        {
            Errors.Add(new Error(error));
        }

        public void AddTechnicalError()
        {
            Errors.Add(new Error("Something Went Wrong"));
        }


        public void AddTechnicalDeleteError()
        {
            Errors.Add(new Error("Something Went Wrong While Deleting"));
        }

        public void AddTechnicalInsertError()
        {
            Errors.Add(new Error("Something Went Wrong While Inserting"));
        }

        public void AddTechnicalUpdateError()
        {
            Errors.Add(new Error("Something Went Wrong While Updating"));
        }

        public void AddErrors(List<string> errors)
        {
            foreach (var error in errors)
            {
                AddError(error);
            }
        }
        public void AddErrors(List<Error> errors)
        {
            foreach (var error in errors)
            {
                AddError(error);
            }
        }

        public void AddNotFoundError()
        {
            Errors.Add(new Error("No Data Found"));
        }

        public string getUIErrors()
        {
            return string.Join("<br/>", Errors.Select(x => x.Message).ToArray());
        }

        public ServiceReturn<TViewModel> ToViewModel<TViewModel>(TViewModel viewModel)
        {
            ServiceReturn<TViewModel> mutated = new ServiceReturn<TViewModel>(Errors);
            mutated.Data = viewModel;
            mutated.Count = Count;
            return mutated;
        }
    }

    public class Error
    {
        public string Message { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }

        public Error()
        {
        }

        public Error(string message)
        {
            Message = message;
        }
    }
}
