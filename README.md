# Identity Manager API
### These apis are used for implementing identity authentication provided by .NET 8
## Version: v1

### /register

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | Success |
| 400 | Bad Request |

### /login

#### POST
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| useCookies | query |  | No | boolean |
| useSessionCookies | query |  | No | boolean |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | Success |

### /refresh

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | Success |

### /confirmEmail

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| userId | query |  | No | string |
| code | query |  | No | string |
| changedEmail | query |  | No | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | Success |

### /resendConfirmationEmail

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | Success |

### /forgotPassword

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | Success |
| 400 | Bad Request |

### /resetPassword

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | Success |
| 400 | Bad Request |

### /manage/2fa

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | Success |
| 400 | Bad Request |
| 404 | Not Found |

### /manage/info

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | Success |
| 400 | Bad Request |
| 404 | Not Found |

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | Success |
| 400 | Bad Request |
| 404 | Not Found |

### /identity/register

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | Success |
| 400 | Bad Request |

### /identity/login

#### POST
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| useCookies | query |  | No | boolean |
| useSessionCookies | query |  | No | boolean |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | Success |

### /identity/refresh

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | Success |

### /identity/confirmEmail

#### GET
##### Parameters

| Name | Located in | Description | Required | Schema |
| ---- | ---------- | ----------- | -------- | ---- |
| userId | query |  | No | string |
| code | query |  | No | string |
| changedEmail | query |  | No | string |

##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | Success |

### /identity/resendConfirmationEmail

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | Success |

### /identity/forgotPassword

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | Success |
| 400 | Bad Request |

### /identity/resetPassword

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | Success |
| 400 | Bad Request |

### /identity/manage/2fa

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | Success |
| 400 | Bad Request |
| 404 | Not Found |

### /identity/manage/info

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | Success |
| 400 | Bad Request |
| 404 | Not Found |

#### POST
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | Success |
| 400 | Bad Request |
| 404 | Not Found |

### /test

#### GET
##### Responses

| Code | Description |
| ---- | ----------- |
| 200 | Success |
