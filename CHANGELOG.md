# Changelog

## < 0.31.0

* Made Rebus - BAM!1

## 0.31.0

* Changed batch API to use `IEnumerable` instead of `params object[]` because the params thing could easily blur which would actually end up as a logical message.

## 0.31.1

* Made Rebus control bus messages `[Serializable]` because for some reason `BinaryFormatter` just likes it that way - applying the attribute makes instances of the class MUCH more serializable.

## 0.32.0

* Updated RabbitMQ client dependency

## 0.32.1

* Fixed handling of exceptions when committing user-provided unit(s) of work

## 0.32.2

* IEnumerable/Add API on SagaFixture
* SQL index on saga_id in saga index table

## 0.32.3

* Re-introduced automatic error queue creation when using RabbitMQ