### Ocm Project
------------

**Geliştirilecek Uygulama:** Sipariş ve kargo yönetim yazılımı. 
Giyim ve Gıda olmak üzere 2 kategori olacak. 
Giyim kategorisine gelen siparişler "aras kargo", gıda ise "yurtiçi kargo"
firmasına düşecek. Giyim'e gelen sipariş kullanıcı tarafından iptal edilebilir ancak Gıda kategorine
gelen siparişleri iptal etmek için üst yönetici onayı gerekmeli.

Kullanılacak Teknoloji : ASP.NET Core API, RDBMS(herhangi biri)

- **Kapsam**:
  1. Entity framework ve Codefirst yaklaşımıyla geliştirilmeli.
  2. Response ve request arasındaki dengeyi Automapper sağlamalı.
  3. Kargo statüleri Enum'dan alınmalı.
  4. Api projesi olacağından servisler Swagger ile verilmeli.

- **Olursa Süper Olur Dediklerimiz**;

  A. Dependency Injection kullanımı.

  B. Docker, docker compose kullanımı.

  C. Sipariş listesi Redis'ten dönmeli. 10 dakikada bir kendini yenilemeli.
