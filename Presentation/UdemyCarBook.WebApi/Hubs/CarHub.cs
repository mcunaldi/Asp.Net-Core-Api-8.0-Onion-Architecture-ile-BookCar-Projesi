﻿using Microsoft.AspNetCore.SignalR;

namespace UdemyCarBook.WebApi.Hubs;

public class CarHub : Hub
{
    private readonly IHttpClientFactory _httpClientFactory;

    public CarHub(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task SendCarCount()
    {
        var client = _httpClientFactory.CreateClient(); //istemci anlamına geliyor.
        var responseMessage = await client.GetAsync("https://localhost:7038/api/Statistics/GetCarCount");
        var value = await responseMessage.Content.ReadAsStringAsync();
        await Clients.All.SendAsync("ReceiveCarCount", value);

    }
}
