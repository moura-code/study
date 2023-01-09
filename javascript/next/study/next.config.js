/** @type {import('next').NextConfig} */
const nextConfig = {
  images: {
    remotePatterns: [
      {
        protocol: 'https',
        hostname: 'github.com',
        port: '',
        pathname: '/moura-code.png',
      },
    ],
  },
  reactStrictMode: true,
}

module.exports = nextConfig
