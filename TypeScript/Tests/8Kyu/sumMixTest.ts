import {assert} from "chai";
import { sumMix } from "../../Exercises/8Kyu/sumMix";

describe("sumMix",() => {
    it("Example tests", () => {
        assert.equal(sumMix([9, 3, '7', '3']), 22);
        assert.equal(sumMix(['5', '0', 9, 3, 2, 1, '9', 6, 7]), 42);
        assert.equal(sumMix(['3', 6, 6, 0, '5', 8, 5, '6', 2,'0']), 41);
    });
});