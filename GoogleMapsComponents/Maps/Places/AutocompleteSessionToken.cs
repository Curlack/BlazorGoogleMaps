﻿using System;
using Microsoft.JSInterop;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GoogleMapsComponents.Maps.Places
{
    public class AutocompleteSessionToken : IDisposable, IJsObjectRef
    {
        private readonly JsObjectRef _jsObjectRef;

        [JsonProperty("GuidString")]
        public Guid Guid => _jsObjectRef.Guid;

        public async static Task<AutocompleteSessionToken> CreateAsync(IJSRuntime jsRuntime)
        {
            var jsObjectRef = await JsObjectRef.CreateAsync(jsRuntime, "google.maps.places.AutocompleteSessionToken");
            var obj = new AutocompleteSessionToken(jsObjectRef);

            return obj;
        }

        private AutocompleteSessionToken(JsObjectRef jsObjectRef)
        {
            _jsObjectRef = jsObjectRef;
        }

        public void Dispose()
        {
            _jsObjectRef.Dispose();
        }
    }
}
