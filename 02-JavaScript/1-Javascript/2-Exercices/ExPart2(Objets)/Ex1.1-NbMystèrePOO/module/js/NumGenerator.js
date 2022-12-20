export default class NumGenerator {
  GenerateNumber(min, max) {
    return Math.floor(Math.random() * (max - min + 1)) + min;
  }
}
