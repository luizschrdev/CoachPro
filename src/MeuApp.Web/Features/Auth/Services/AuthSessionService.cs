using Microsoft.JSInterop;

namespace MeuApp.Web.Features.Auth.Services;

public sealed class AuthSessionService
{
    private const string RoleStorageKey = "meuapp.auth.role";
    private const string NameStorageKey = "meuapp.auth.name";
    private readonly IJSRuntime _jsRuntime;
    private bool _loaded;

    public AuthSessionService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public string? Role { get; private set; }
    public string? Name { get; private set; }
    public bool IsAuthenticated => Role is not null;
    public bool IsAthlete => string.Equals(Role, "athlete", StringComparison.Ordinal);
    public bool IsCoach => string.Equals(Role, "coach", StringComparison.Ordinal);

    public async Task LoadAsync()
    {
        if (_loaded)
        {
            return;
        }

        Role = await _jsRuntime.InvokeAsync<string?>("localStorage.getItem", RoleStorageKey);
        Name = await _jsRuntime.InvokeAsync<string?>("localStorage.getItem", NameStorageKey);
        _loaded = true;
    }

    public async Task LoginAsync(string role, string name)
    {
        Role = role;
        Name = name;
        _loaded = true;

        await _jsRuntime.InvokeVoidAsync("localStorage.setItem", RoleStorageKey, role);
        await _jsRuntime.InvokeVoidAsync("localStorage.setItem", NameStorageKey, name);
    }

    public async Task LogoutAsync()
    {
        Role = null;
        Name = null;
        _loaded = true;

        await _jsRuntime.InvokeVoidAsync("localStorage.removeItem", RoleStorageKey);
        await _jsRuntime.InvokeVoidAsync("localStorage.removeItem", NameStorageKey);
    }
}
