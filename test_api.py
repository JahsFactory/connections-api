import requests

url = "http://localhost:5062/api/random"

try:
    response = requests.get(url)
    response.raise_for_status()
    print("Status Code:", response.status_code)
    print("Response JSON:")
    print(response.json())
except requests.RequestException as e:
    print("Error:", e)
