
using Microsoft.JSInterop;

namespace BlazorApp1
{
	public class AlertService : IAsyncDisposable
	{
		readonly Lazy<Task<IJSObjectReference>> ijsObjectReference;

		public AlertService(IJSRuntime ijsRuntime)
		{
			this.ijsObjectReference = new Lazy<Task<IJSObjectReference>>(()=>
			ijsRuntime.InvokeAsync<IJSObjectReference>("import", "./content/BlazorApp3/Page/Home.razor.js").AsTask());
		}

		public ValueTask DisposeAsync()
		{
			throw new NotImplementedException();
		}
	}
}
