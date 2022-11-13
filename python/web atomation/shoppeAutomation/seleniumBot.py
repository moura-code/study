import sys
import time

from selenium import webdriver
from selenium.webdriver.chrome.service import Service
from webdriver_manager.chrome import ChromeDriverManager
from selenium.webdriver.common.by import By
link,password,conta = sys.argv[1:]

mobile_emulation = { "deviceName": "iPhone SE" }
chrome_options = webdriver.ChromeOptions()
chrome_options.add_experimental_option("mobileEmulation", mobile_emulation)
driver = webdriver.Chrome(service=Service(ChromeDriverManager().install()),options=chrome_options) #sometimes you have to insert your execution path
driver.get('https://login.aliexpress.com/?return_url=https%3A%2F%2Fwww.aliexpress.com%2Fp%2Forder%2Findex.html%3Fspm%3Da2g0o.home.1000001.32.10751c91OYYvoS')
driver.implicitly_wait(10) 
driver.find_element(By.XPATH, '/html/body/div/div[2]/div/div[2]/div/div/div[1]/span/span[1]/input').send_keys(conta)
driver.implicitly_wait(10)
driver.find_element(By.XPATH, '/html/body/div/div[2]/div/div[2]/div/div/div[2]/span/span[1]/input').send_keys(password)
driver.implicitly_wait(10)
driver.find_element(By.XPATH, '/html/body/div/div[2]/div/div[2]/div/div/button[2]').click()
time.sleep(5)
driver.get(link)
time.sleep(15)
driver.find_element(By.XPATH, '/html/body/div[4]/div/div/div[2]/div[2]/div/div[1]').click()
time.sleep(15)




