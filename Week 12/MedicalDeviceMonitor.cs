import serial
import time

class MedicalDeviceMonitor:
    def __init__(self, port: str, baud_rate: int = 9600, timeout: int = 2):
        """Initialize serial connection."""
        self.port = port
        self.baud_rate = baud_rate
        self.timeout = timeout
        self.connection = None
    
    def connect(self):
        """Establish connection with the device."""
        try:
            self.connection = serial.Serial(self.port, self.baud_rate, timeout=self.timeout)
            time.sleep(2)  # Allow connection to stabilize
            print("Connected to device.")
        except serial.SerialException as e:
            print(f"Connection failed: {e}")
    
    def read_data(self):
        """Read and return data from the device."""
        if self.connection and self.connection.is_open:
            try:
                data = self.connection.readline().decode('utf-8').strip()
                return data
            except Exception as e:
                print(f"Error reading data: {e}")
        return None
    
    def close(self):
        """Close the serial connection."""
        if self.connection and self.connection.is_open:
            self.connection.close()
            print("Connection closed.")

if __name__ == "__main__":
    device = MedicalDeviceMonitor(port="COM3")  # Change port as needed
    device.connect()
    
    for _ in range(10):  # Read data 10 times
        data = device.read_data()
        if data:
            print(f"Received: {data}")
        time.sleep(1)
    
    device.close()
