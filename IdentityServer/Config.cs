﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> Ids =>
            new IdentityResource[]
            {
                new IdentityResources.Profile(),
                new IdentityResources.OpenId(),
            };

        public static IEnumerable<ApiResource> Apis =>
            new ApiResource[] 
            {
                new ApiResource("api1","MY API"),
             };
        
        public static IEnumerable<Client> Clients =>
        new Client[]
        {
            new Client{
                ClientId = "client",
                //using clientid and secret for authentication
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = {new Secret("secret".Sha256())},
                //client allowed scopes to access
                AllowedScopes = {"api1"}
            },
            new Client
        {
            ClientId = "mvc",
            ClientSecrets = { new Secret("secret".Sha256()) },

            AllowedGrantTypes = GrantTypes.Code,
            RequireConsent = false,
            RequirePkce = true,

            // where to redirect to after login
            RedirectUris = { "http://localhost:5002/signin-oidc" },

            // where to redirect to after logout
            PostLogoutRedirectUris = { "http://localhost:5002/signout-callback-oidc" },

            AllowedScopes = new List<string>
            {
                IdentityServerConstants.StandardScopes.OpenId,
                IdentityServerConstants.StandardScopes.Profile,
                "api1"
            },
            AllowOfflineAccess = true

        }
        };
        // public static IEnumerable<Client> Clients =>
        //     new Client[] 
        //     { };

        
    }
}