import requests

url = "https://connections-api-app.azurewebsites.net/api/daily"

try:
    response = requests.get(url, timeout=10, verify=False)
    response.raise_for_status()
    print("Status Code:", response.status_code)
    print("Response JSON:")
    print(response.json())
except requests.RequestException as e:
    print("Error:", e)
