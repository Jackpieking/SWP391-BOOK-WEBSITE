using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Threading.Tasks;

namespace Helper;

public class CustomDateTimeModelBinder : IModelBinder
{
	public Task BindModelAsync(ModelBindingContext bindingContext)
	{
		if (bindingContext == null)
		{
			throw new ArgumentNullException(nameof(bindingContext));
		}

		// Lấy ModelName - tên thuộc tính binding
		var modelName = bindingContext.ModelName;

		// Lấy giá trị gửi đến
		var valueProviderResult = bindingContext.ValueProvider.GetValue(modelName);

		// Không có giá trị gửi đến
		if (valueProviderResult == ValueProviderResult.None)
		{
			return Task.CompletedTask;
		}

		// Thiết lập cho ModelState giá trị bindinng
		bindingContext.ModelState.SetModelValue(modelName, valueProviderResult);

		// Đọc giá trị đầu tiên gửi đêns
		var value = valueProviderResult.FirstValue;

		// Gán giá trị vào thuộc tính
		bindingContext.Result = ModelBindingResult.Success(DateOnly.Parse(value));

		return Task.CompletedTask;

	}
}