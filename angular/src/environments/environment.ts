 import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44354/',
  redirectUri: baseUrl,
  clientId: 'BookStore_App',
  responseType: 'code',
  scope: 'offline_access BookStore',
  requireHttps: true,
};

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'BookStore',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44354',
      rootNamespace: 'BookStore',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
} as Environment;
