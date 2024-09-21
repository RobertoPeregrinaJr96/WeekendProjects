// services/ApiService.js
import axios from "axios";

const apiClient = axios.create({
  baseURL: "https://localhost:5001", // .NET API base URL
  withCredentials: false,
  headers: {
    Accept: "application/json",
    "Content-Type": "application/json",
  },
});

export default {
  getWeatherForecast() {
    return apiClient.get("/welcome");
  },
};
