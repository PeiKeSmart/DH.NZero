using Microsoft.AspNetCore.Mvc;
using NewLife.Reflection;
using NewLife.Remoting.Extensions;

namespace Zero.WebApi.Controllers;

/// <summary>接口探针</summary>
[ApiFilter]
[ApiController]
[Route("[controller]")]
public class ApiController : ControllerBase
{
    private static readonly String _OS = Environment.OSVersion + "";

    /// <summary>服务器信息，用户健康检测</summary>
    /// <param name="state">状态信息</param>
    /// <returns></returns>
    [HttpGet]
    public Object Get(String state)
    {
        var asmx = AssemblyX.Entry;
        var conn = HttpContext.Connection;
        var remote = conn.RemoteIpAddress;
        if (remote.IsIPv4MappedToIPv6) remote = remote.MapToIPv4();
        var ip = HttpContext.GetUserHost();

        var rs = new
        {
            asmx?.Name,
            asmx?.Title,
            asmx?.FileVersion,
            asmx?.Compile,
            OS = _OS,

            UserHost = ip + "",
            Remote = remote + "",
            Port = conn.LocalPort,
            Time = DateTime.Now,
            State = state,
        };

        return rs;
    }

    /// <summary>GET纯文本回显</summary>
    /// <param name="data">查询参数data</param>
    /// <returns></returns>
    [HttpGet("echo")]
    [Produces("text/plain")]
    public ContentResult EchoGet([FromQuery] String data) => Content(data ?? String.Empty, "text/plain; charset=utf-8");

    /// <summary>POST纯文本回显</summary>
    /// <returns></returns>
    [HttpPost("echo")]
    [Consumes("text/plain", "application/x-www-form-urlencoded", "application/octet-stream")]
    [Produces("text/plain")]
    public async Task<ContentResult> EchoPost()
    {
        if (Request.Body.CanSeek) Request.Body.Position = 0;

        using var reader = new StreamReader(Request.Body, leaveOpen: true);
        var body = await reader.ReadToEndAsync();

        if (Request.Body.CanSeek) Request.Body.Position = 0;

        return Content(body, "text/plain; charset=utf-8");
    }
}